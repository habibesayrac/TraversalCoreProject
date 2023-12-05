using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class Context : DbContext
    {
    //    public  Context(DbContextOptions<Context> options) : base(options)
    //    {
                    
        
    //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=MyVisitDB;integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
