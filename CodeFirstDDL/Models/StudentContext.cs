using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDDL.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = StudentDB; Integrated Security = True; MultipleActiveResultSets=True")
        {

        }

        public DbSet<State> States { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}