using System.Data.Entity;

namespace EFExample
{
    public class ExampleDBContext : DbContext
    {
    //    public ExampleDBContext() : base("sample")
    //    {
    //        //Set db intializer for default value of dictionary on create db
    //        //Database.SetInitializer<ExampleDBContext>(new ExampleDbIntializer());
    //    }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        //public DbSet<Department> Departments { get; set; }

    }
}