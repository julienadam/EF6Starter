using System;

namespace EF6Starter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new MyDbContext())
            {
                ctx.MyEntities.Add(new MyEntity() { Name = "Alice" });
                ctx.SaveChanges();
            }
        }
    }
}