using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Product Data access  
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
