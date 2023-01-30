using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using NetECommerce.BLL.IntRepo;
using NetECommerce.BLL.SingletonPattern;
using NetECommerce.DAL.Context;
using NetECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace NetECommerce.BLL.BaseRepo
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected ProjectContext _db;
        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }

        //Değişikliği kaydetme metodu
        protected void Save()
        {
            _db.SaveChanges();
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddList(List<T> listItem)
        {
            //AddRange() metodu birden çok nesneyi liste halinde eklemeye yarıyor.
            _db.Set<T>().AddRange(listItem);
            Save();
        }

        public void Delete(T item)
        {
            item.Status = Entity.Enum.Status.Deleted;
            item.DeletedDate= DateTime.Now;
            Save();
        }

        public void DeleteList(List<T> listItem)
        {
            foreach (T item in listItem)
            {
                Delete(item);
            }
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetDeleteds()
        {
            return Where(x => x.Status == Entity.Enum.Status.Deleted);
        }

        public List<T> GetUpdateds()
        {
            return Where(x => x.Status == Entity.Enum.Status.Updated);
        }

        public void Remove(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void RemoveList(List<T> listItem)
        {
            _db.Set<T>().RemoveRange(listItem);
            Save();
        }

        public void Update(T item)
        {
            item.Status= Entity.Enum.Status.Updated;
            item.UpdatedDate= DateTime.Now;
            T update = Find(item.Id);
            _db.Entry(update).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateList(List<T> listItem)
        {
            foreach (T item in listItem)
            {
                Update(item);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }
    }
}
