using System.Data.Entity;

namespace EF6Starter
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbConnection")
        {
            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        public DbSet<MyEntity> MyEntities { get; set; }
    }
}