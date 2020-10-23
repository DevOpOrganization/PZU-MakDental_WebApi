using Microsoft.EntityFrameworkCore;
using Models.Entety;

namespace AServerData
{
    public class MdDbContext : DbContext
    {
        public MdDbContext(DbContextOptions<MdDbContext> options):base(options) { }


        public DbSet<Blog> Blogs { get; set; }



    }
}
