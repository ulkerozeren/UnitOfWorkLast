using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.RepositoryInterfaces;

namespace testUnitofWork2.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly XContext _xContext;
        public Repository(XContext xContext)
        {
            _xContext = xContext;
        }
        public void Add(T model)
        {
            _xContext.Set<T>().Add(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _xContext.Set<T>().ToList();
        }

        public T GetItem(int id)
        {
            return _xContext.Set<T>().Find(id);
        }
    }
}
