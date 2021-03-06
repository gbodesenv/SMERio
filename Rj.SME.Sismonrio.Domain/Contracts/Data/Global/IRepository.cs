﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Rj.SME.Sismonrio.Domain.Contracts.Data.Global
{
    using Filters;
    public interface IRepository<T, F> : IDisposable
        where T : class //entidade
        where F : Filter //filter
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(int id);

        T GetById(int id);

        IEnumerable<T> All(int skip = 0, int take = 25);

        IEnumerable<T> Where(F filter);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);

        IEnumerable<T> WhereRaw(Expression<Func<T, bool>> predicate);

        int WhereSum(F filter);
    }
}
