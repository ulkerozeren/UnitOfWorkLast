using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testUnitofWork2.Entities;
using testUnitofWork2.RepositoryInterfaces;

namespace testUnitofWork2.Repositories
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        private readonly XContext _xContext;
        public CategoryRepository(XContext xContext):base(xContext)
        {
            _xContext=xContext;
        }
    }
}
