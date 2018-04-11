namespace MoneyExchangeWinForm
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    class ObjectsManageStateMachine<T> : IObjectsManageStateMachine<T>
    {
        public int CurrentIndex { get; set; } = 0;

        public int CollectionCount { get => Collection.Count; }

        public State CurrentState { get; set; }

        public T CurrentInstance => ((List<T>)Collection)[CurrentIndex];

        public ICollection<T> Collection { get; set; }

        public IObjectsManageStateMachine<T> Save(T t)
        {
            if (CurrentState == State.Adding)
            {
                Append(t);
                CurrentIndex = CollectionCount - 1;
            }
            else if (CurrentState == State.Editing)
            {
                Edit(CurrentIndex, t);
            }

            return this;
        }

        public IObjectsManageStateMachine<T> Append(T t)
        {
            ((List<T>)Collection).Add(t);
            return this;
        }

        public IObjectsManageStateMachine<T> Edit(int currentIndex, T t)
        {
            ((List<T>)Collection)[CurrentIndex] = t;
            return this;
        }

        public IObjectsManageStateMachine<T> Delete(int currentIndex)
        {
            ((List<T>)Collection).RemoveAt(CurrentIndex);
            CurrentIndex = CurrentIndex > 0 ? CurrentIndex -= 1 : CurrentIndex;
            return this;
        }

        public T GetFirst()
        {
            CurrentIndex = 0;
            return CurrentInstance;
        }

        public T GetLast()
        {
            CurrentIndex = CollectionCount - 1;
            return CurrentInstance;
        }

        public T GetPrevious()
        {
            CurrentIndex = CurrentIndex >= 1 ? CurrentIndex -= 1 : CurrentIndex;
            return CurrentInstance;
        }

        public T GetNext()
        {
            if (CurrentIndex <= CollectionCount - 2)
            {
                CurrentIndex += 1;
            }
            return CurrentInstance;
        }
    }
}
