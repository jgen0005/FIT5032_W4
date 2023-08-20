using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Fit5032_MyCodeFirst.Models;
using System.Diagnostics;
using Fit5032_MyCodeFirst.DAL;

namespace Fit5032_MyCodeFirst.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniContext>
    {
        protected override void Seed(UniContext context)
        {
            var units = new List<Unit>
            {
                new Unit{ID=1,Name="fit5032",Description="test unit"},
            };
            units.ForEach(s => context.Units.Add(s));
            context.SaveChanges();

            var students = new List<Student>
            {
            new Student{ID=1,FirstName="Jingyun",LastName="Geng", Units= new List<Unit>{ units[0] } },
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}