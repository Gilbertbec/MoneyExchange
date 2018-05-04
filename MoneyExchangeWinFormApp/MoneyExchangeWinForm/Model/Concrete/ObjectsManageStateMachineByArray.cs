namespace MoneyExchangeWinForm.Model.Concrete
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ObjectsManageStateMachineByArray<T> : IObjectsManageStateMachine<T>
    {
        private int SizeOfArray => GlobalConfig.SizeOfArray; 

        public int CurrentIndex { get; set; } = 0;

        public int CollectionCount => Collection.Count;

        public State CurrentState { get; set; }

        public T CurrentInstance
        {
            get
            {
                T[] ts = new T[SizeOfArray];
                Collection.CopyTo(ts, 0);
                return ts[CurrentIndex];
            }
        }

        public ICollection<T> Collection { get; set; }

        public IObjectsManageStateMachine<T> Save(T t)
        {
            if (CurrentState == State.Adding)
            {
                Append(t);
                CurrentIndex = Collection.Count(x => x != null) - 1;
            }
            else if (CurrentState == State.Editing)
            {
                Edit(CurrentIndex, t);
            }

            return this;
        }

        public IObjectsManageStateMachine<T> Append(T t)
        {
            T[] ts = new T[SizeOfArray];
            Collection.CopyTo(ts, 0);
            ts[CollectionCount] = t;

            Collection = ts.Where(x => x != null).ToArray();
            return this;
        }

        public IObjectsManageStateMachine<T> Edit(int currentIndex, T t)
        {
            T[] ts = new T[SizeOfArray];
            Collection.CopyTo(ts, 0);
            ts[currentIndex] = t;

            Collection = ts.Where(x => x != null).ToArray();
            return this;
        }

        public IObjectsManageStateMachine<T> Delete(int currentIndex)
        {
            T[] ts = new T[SizeOfArray];
            Collection.CopyTo(ts, 0);
            Array.Clear(ts, currentIndex, 1);
            ts = ts.Where(x => x != null).ToArray();
            Array.Resize(ref ts, SizeOfArray);
            Collection = ts.Where(x => x != null).ToArray();

            CurrentIndex = currentIndex > 0 ? CurrentIndex -= 1 : CurrentIndex;
            return this;
        }

        public T GetFirst()
        {
            CurrentIndex = 0;
            return CurrentInstance;
        }

        public T GetLast()
        {
            CurrentIndex = Collection.Count(x => x != null) - 1;
            return CurrentInstance;
        }

        public T GetPrevious()
        {
            CurrentIndex = CurrentIndex >= 1 ? CurrentIndex -= 1 : CurrentIndex;
            return CurrentInstance;
        }

        public T GetNext()
        {
            if (CurrentIndex <= Collection.Count(x => x != null) - 2)
            {
                CurrentIndex += 1;
            }
            return CurrentInstance;
        }
    }
}
