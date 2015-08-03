namespace ManyToManyEasy.Migrations
{
    using ManyToManyEasy.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyEasy.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyEasy.Models.SchoolDbContext context)
        {
            var students = new Student[] 
            {
                new Student { LastName = "Fleming", FirstName = "Jeremy"},
                new Student { LastName = "Brittain",FirstName = "Nick"}
            };

            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);
            context.SaveChanges();

            var courses = new Course[] 
            {
                new Course { Name = "Intro to Math", Code = "MATH0304"},
                new Course { Name = "Intro to C#", Code = "CSHARP100"},
                new Course { Code = "CSHARP200", Name = "Adv C#"}
            };

            context.Courses.AddOrUpdate(c => c.Code, courses);
            context.SaveChanges();


            var jeremy = context.Students.FirstOrDefault(s => s.FirstName == "Jeremy");
            var nick = context.Students.FirstOrDefault(s => s.FirstName == "Nick");

            if (!nick.Courses.Any(c => c.CourseId == courses[0].Id))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = courses[0].Id
                });
            }

            if (!nick.Courses.Any(c => c.CourseId == courses[1].Id))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = courses[1].Id
                });
            }

        }
    }
}
