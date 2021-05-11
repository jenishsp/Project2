using System.Data.Entity;

namespace Project2.ObjectModel
{
    public class Project2DB : DbContext
    {
        public Project2DB() 
            : base("name=Project1DB")
        {            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
