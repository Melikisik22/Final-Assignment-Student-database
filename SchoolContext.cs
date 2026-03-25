using System.Data.Entity;

namespace StudentCodeFirstApp
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Student> Students { get; set; }
    }
}
