using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //where T:class : class demek referans tip olabilir demektir.
    //IEntity: IEntity veya IEntity i implemente eden class ları kullanabilirsin demek
    //new(): new lenebilir olmalı
    //Burada amaç sistemi yalnızca veritabanı nesneleri ile çalışabilmesini sağlamak için 
    //kısıtlamalar getirerek olası hataların önüne geçmektir.

    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
