using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

        //List<Category> GetAll();

        //void Add(Category category);
        //void Update(Category category);
        //void Delete(Category category);

        //List<Category> GetAllByCategory(int categoryId);

        //List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //Category Get(Func<object, bool> p);
    }
}
