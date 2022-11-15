using System.Collections.Generic;
using System.Data.Entity;

namespace EF6Starter
{
    public class MyDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.MyEntities.Add(new MyEntity { Name = "Foo" });
            context.MyEntities.Add(new MyEntity { Name = "Bar" });
            context.MyEntities.Add(new MyEntity { Name = "Baz" });

            base.Seed(context);
        }
    }
}