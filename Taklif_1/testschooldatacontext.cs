using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taklif_1
{
    internal class testschooldatacontext:DbContext
    {
        public testschooldatacontext():base("Data Source=.;Initial Catalog=testschool;Integrated Security=True")
        {

        }
        public DbSet<Class2> testschools { get; set; }
    }
}
