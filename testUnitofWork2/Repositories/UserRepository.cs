using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.Entities;
using testUnitofWork2.RepositoryInterfaces;

namespace testUnitofWork2.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
