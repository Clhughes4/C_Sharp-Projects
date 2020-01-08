using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstProject.Models;
namespace CodeFirstProject.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Jason",LastName="Adams",EnrollmentDate=DateTime.Parse("2007-09-01")},
            new Student{FirstMidName="Leonardo",LastName="Pascoli",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Amber",LastName="Christenson",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gabriel",LastName="Hymes",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Brielle",LastName="Erickson",EnrollmentDate=DateTime.Parse("2008-09-01")},
            new Student{FirstMidName="Liam",LastName="Stone",EnrollmentDate=DateTime.Parse("2010-09-01")},
            new Student{FirstMidName="Aurora",LastName="Naples",EnrollmentDate=DateTime.Parse("2006-09-01")},
            new Student{FirstMidName="Tanner",LastName="Shores",EnrollmentDate=DateTime.Parse("2011-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1168,Title="Chemistry",Credits=3,},
            new Course{CourseID=4048,Title="Psychology",Credits=4,},
            new Course{CourseID=4077,Title="Anatomy",Credits=3,},
            new Course{CourseID=1134,Title="Calculus",Credits=4,},
            new Course{CourseID=3367,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2255,Title="Robotics",Credits=3,},
            new Course{CourseID=2081,Title="Physics",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1168,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4048,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4077,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1134,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3367,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2255,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1168},
            new Enrollment{StudentID=4,CourseID=1168,},
            new Enrollment{StudentID=4,CourseID=4048,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4077,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1134},
            new Enrollment{StudentID=7,CourseID=3367,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}