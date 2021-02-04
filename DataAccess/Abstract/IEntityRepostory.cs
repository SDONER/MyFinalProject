using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //Class : Referans tip
    //IEntitiy olabilir vaya Ientitiy implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepostory<T> where T:class,IEntitiy,new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
