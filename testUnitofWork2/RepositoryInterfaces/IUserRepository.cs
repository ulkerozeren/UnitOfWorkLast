using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.Entities;

namespace testUnitofWork2.RepositoryInterfaces
{
    public interface IUserRepository: IRepository<User>
    {
    }
}
