using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taklif_1
{
    public class Class2 : ClassProp
    {
        testschooldatacontext db = new testschooldatacontext();
        public void Insertef()
        {
            db.testschools.Add(new Class2
            {
                CodeMeli = this.CodeMeli,
                LastName = this.LastName,
                Name = this.Name,
            });
            db.SaveChanges();
        }
        public void Deleteef()
        {
            var students = db.testschools.Where(x => x.CodeMeli == this.CodeMeli).First();
            db.testschools.Remove(students);
            db.SaveChanges();
        }
        public void Updateef()
        {
            var students=db.testschools.Where(x=> x.CodeMeli==this.CodeMeli).First();
            students.LastName=this.LastName;
            students.Name=this.Name;
            db.SaveChanges();
        }
        public List<Class2> Selectef()
        {
            var students=db.testschools.ToList();
            return students.ToList();
        }
    }
}
