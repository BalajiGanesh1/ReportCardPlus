using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ReportCardPlus.Models;

namespace ReportCardPlus.DAL
    {
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
        {
        protected override void Seed(SchoolContext context)
            {
            var students = new List<Student>
            {
            new Student{Name="SuperMan",English=50,Maths=100,Science=60,Total=210,Percentage=70},
            new Student{Name="BatMan",English=53,Maths=97,Science=63,Total=213,Percentage=71},
            new Student{Name="SpiderMan",English=90,Maths=35,Science=11,Total=136,Percentage=45.33},
            new Student{Name="Joker",English=60,Maths=60,Science=60,Total=180,Percentage=60},
            new Student{Name="BoomerMan",English=32,Maths=76,Science=67,Total=175,Percentage=58.33},
            new Student{Name="Jack Sparrow",English=35,Maths=92,Science=87,Total=214,Percentage=71.33},
            new Student{Name="Hulk",English=100,Maths=100,Science=100,Total=300,Percentage=100},
            new Student{Name="Captain America",English=89,Maths=95,Science=98,Total=282,Percentage=94},
            new Student{Name="Flash",English=81,Maths=45,Science=91,Total=217,Percentage=72.33},
            new Student{Name="Captain Marvel",English=78,Maths=56,Science=69,Total=203,Percentage=67.67},
            new Student{Name="King Booker",English=76,Maths=100,Science=100,Total=276,Percentage=92},
            new Student{Name="IronMan",English=67,Maths=53,Science=98,Total=218,Percentage=72.67},
            new Student{Name="Pikachu",English=51,Maths=80,Science=15,Total=146,Percentage=48.67}
                                     

            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var users = new List<User>
            {
            new User{EmailID="teacher@ghss.com",Password="123456"},
            new User{EmailID="123@123.com",Password="123456"},
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            
            }
        }
    }