using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    //NuGet
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
        //EfEntityRepositoryBase class ında IProductDal ın istediği metodlar zaten olduğundan
        //EfProductDal EfEntityRepository i inherit ettiğinde IProductDal ın istediği metodlar
        //EfProductDal içerisinde oluşmutur.
        
    }
}
