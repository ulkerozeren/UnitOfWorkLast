using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.Repositories;
using testUnitofWork2.RepositoryInterfaces;

namespace testUnitofWork2
{
    public class UnitofWork: IUnitOfWork
    {
        private readonly XContext _xContext;

        public UnitofWork(XContext xContext)
        {
            _xContext = xContext;
            categoryRepository = new CategoryRepository(xContext);
            userRepository = new UserRepository(xContext);
        }

        public ICategoryRepository categoryRepository { get; set; }
        public IUserRepository userRepository { get; set; }

        public int Complete()
        {
           return _xContext.SaveChanges();
        }

        public void Dispose()
        {
            _xContext.Dispose();
        }
    }
}
