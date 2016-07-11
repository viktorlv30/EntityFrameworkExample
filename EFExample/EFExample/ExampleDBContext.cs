using System.Data.Entity;

namespace EFExample
{
    public class ExampleDBContext : DbContext
    {
        public ExampleDBContext() : base("sample")
        {
            //Set db intializer for default value of dictionary on create db
            //Database.SetInitializer<ExampleDBContext>(new ExampleDbIntializer());
        }
        
    }
}