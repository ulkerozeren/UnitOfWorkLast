using Microsoft.EntityFrameworkCore;
using testUnitofWork2.Entities;

namespace testUnitofWork2
{
    public class XContext:DbContext
    {
        public XContext(DbContextOptions<XContext> dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
