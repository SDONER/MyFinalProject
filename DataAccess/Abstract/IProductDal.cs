using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepostory<Product>
    {
       // List<Product> GetAll();

       // List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
