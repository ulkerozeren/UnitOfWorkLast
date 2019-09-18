using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testUnitofWork2.RepositoryInterfaces
{
    public interface IRepository<T> where T: class
    {
        void Add(T model);
        T GetItem(int id);
        IEnumerable<T> GetAll();
    }
}
