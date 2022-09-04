using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InProductMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product> {
                new Product {ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=5,UnitsInStock=15 },
                new Product {ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=100,UnitsInStock=3 },
                new Product {ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=150,UnitsInStock=2 },
                new Product {ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=120,UnitsInStock=65 },
                new Product {ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=80,UnitsInStock=1 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ Language İntegrated Query Dile Gömülü Sorgulama
            Product productToDelete;// = null;
            //LINQ yok ise yapılacak olan silme işlemi bu şekilde yapılmalıdır.
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //Aşağıdaki satırda LINQ kullanımı yapılmaktadır. Bu yapı ile bir liste tek tek dolaşılır ve istenen şart aranır.
            //p=> işareti her p için demek ve p bir takma isimdir foreach deki gibi => lambda işaretidir.
            //SingleOrDefault LINQ metodudur ve foreach ile aynı görevi yapar
            //parantez içerisindeki eşitlik ile de if bloklarının görevi yapılır.
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategories(int categoryId)
        {
            //Buradaki where sql deki where gibi şartı arar ve parantez içerisindeki şartı sağlayan productlar için bir liste döndürür.
            //Parantez içerisine istenildiği kadar şart girilebilir.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim product ın id sinin eşit oldğu listedeki product ı bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;

        }
    }
}
