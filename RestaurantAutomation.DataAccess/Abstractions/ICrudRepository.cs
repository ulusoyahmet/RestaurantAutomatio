﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.DataAccess.Abstractions
{
    public interface ICrudRepository<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetByID(Guid id);
        IEnumerable<T> GetAll();

        //IfEntityExists metoduna parametre olarak lambda expression yazabiliriz.
        bool IfEntityExists(Expression<Func<T, bool>> filter);

    }
}
