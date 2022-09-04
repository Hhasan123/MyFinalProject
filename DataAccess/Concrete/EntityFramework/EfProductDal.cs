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
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using= Disposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEtity = context.Entry(entity); //referansı yakala
                addedEtity.State = EntityState.Added;   // nesneyi ekle
                context.SaveChanges();                  // ve kaydet

            }
        }

        public void Delete(Product entity)
        {
            //using= Disposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var deleteEtity = context.Entry(entity); //referansı yakala
                deleteEtity.State = EntityState.Deleted;   // nesneyi ekle
                context.SaveChanges();                  // ve kaydet

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            //using= Disposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEtity = context.Entry(entity); //referansı yakala
                updatedEtity.State = EntityState.Modified;   // nesneyi ekle
                context.SaveChanges();                  // ve kaydet

            }
        }
    }
}
