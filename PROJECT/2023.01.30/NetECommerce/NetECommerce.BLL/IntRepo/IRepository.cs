using NetECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NetECommerce.BLL.IntRepo
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetUpdateds();
        List<T> GetDeleteds();


        void Add(T item);
        void AddList(List<T> listItem);
        void Delete(T item);
        void DeleteList(List<T> listItem);
        void Update(T item);
        void UpdateList(List<T> listItem);
        void Remove(T item);
        void RemoveList(List<T> listItem);


        List<T> Where(Expression<Func<T, bool>> exp);

        T Find(int id);
    }
}
