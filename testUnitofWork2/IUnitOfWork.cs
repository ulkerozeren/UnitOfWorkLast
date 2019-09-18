using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.RepositoryInterfaces;

namespace testUnitofWork2
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository categoryRepository { get; set; }
        IUserRepository userRepository { get; set; }
        int Complete();
    }
}
