using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore3._1_Store.Repository
{
    interface IBaseRepository<T> where T :class  // T is a type of class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool IsExists(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
