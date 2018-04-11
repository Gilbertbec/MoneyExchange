namespace MoneyExchangeWinForm
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    interface IObjectsManageStateMachine<T>
    {
        int CurrentIndex { get; set; }

        int CollectionCount { get; }

        State CurrentState { get; set; }

        T CurrentInstance { get; }

        ICollection<T> Collection { get; set; }

        IObjectsManageStateMachine<T> Save(T t);

        IObjectsManageStateMachine<T> Append(T t);

        IObjectsManageStateMachine<T> Delete(int currentIndex);

        IObjectsManageStateMachine<T> Edit(int currentIndex, T t);

        T GetFirst();

        T GetLast();

        T GetNext();

        T GetPrevious();
    }
}
