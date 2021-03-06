﻿namespace EpamTask4.DAL.Repository
{
    using System;
    using System.Collections.Generic;

    public interface IGenericRepository<T> where T : class
    {
        void Create(T item);
        T Find(T item);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
    }
}
