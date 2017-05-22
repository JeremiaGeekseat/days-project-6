using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        List<T> ViewAll();
        T View(int? id);
        void Dispose();
    }
}
