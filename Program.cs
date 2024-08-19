using Entity_Framework2.Context;
using Entity_Framework2.Models;
using Entity_FrameWork2.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIdbContext dbContext = new ITIdbContext();
            #region CRUD Operations
            #region Student Table
            //Student st02 = new Student()
            //{
            //    Fname = "Omar",
            //    LName = "Ibra",
            //    Age = 25,
            //    Address = "Cairo",
            //    DepId = 1,
            //};
            //Student st01 = new Student()
            //{
            //    Fname = "Mido",
            //    LName = "Ibra",
            //    Age = 26,
            //    Address = "Cairo",
            //    DepId = 1,
            //};
            #endregion
            #region Department Table
            //Department D01 = new Department()
            //{
            //    Id = 1,
            //    Name="MANAGMENT",
            //    HiringDate=5,
            //    InsId=1,

            //};
            //Department D02 = new Department()
            //{
            //    Id = 2,
            //    Name = "Teachers",
            //    HiringDate = 9,
            //    InsId = 2,

            //};

            #endregion
            #region Instructor
            //Instructor ins01 = new Instructor()
            //{
            //    Name = "Mido",
            //    Address = "Cairo",
            //    Bonus = 50,
            //    Salary = 5000,
            //    HourRate = 38,
            //    DepId = 1,
            //};
            //Instructor ins02 = new Instructor()
            //{
            //    Name = "Omar",
            //    Address = "Cairo",
            //    Bonus = 50,
            //    Salary = 5000,
            //    HourRate = 38,
            //    DepId = 1,
            //};
            #endregion
            #region Course
            //Course course01 = new Course()
            //{
            //    Name = "CS",
            //    Duration = 5,
            //    Description = "BAD",
            //    TopId = 1,
            //};
            //Course course02 = new Course()
            //{
            //    Name = "DS",
            //    Duration = 4,
            //    Description = "BAD",
            //    TopId = 2,
            //};
            #endregion

            #region Insert
            #region Student
            //Console.WriteLine(dbContext.Entry(st02).State);
            //dbContext.Student.Add(st02);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(st02).State);
            //dbContext.Student.Add(st01);
            //dbContext.SaveChanges();  
            #endregion
            #region Department
            //dbContext.Department.Add(D01);
            //dbContext.SaveChanges();
            #endregion
            #region Instrutor
            //dbContext.Instructor.Add(ins01);
            //dbContext.Instructor.Add(ins02);
            //dbContext.SaveChanges();
            #endregion
            #region Course
            //dbContext.Course.Add(course01);
            //dbContext.SaveChanges();
            //dbContext.Course.Add(course02);
            //dbContext.SaveChanges();


            #endregion
            #endregion

            #region Select

            //Console.WriteLine(student?.Fname??"Null");
            #region Instructor
            //var INstructor = (from s in dbContext.Instructor
            //                  where s.Name =="Omar"
            //                  select s).FirstOrDefault();
            //Console.WriteLine(INstructor?.Name??"N/A");
            #endregion
            #region Course
            //var course = (from c in dbContext.Course
            //              where c.Id == 1
            //              select c
            //            ).FirstOrDefault();
            //Console.WriteLine(course.Name);
            #endregion
            #endregion
            #region Update
            #region Student
            //var student = (from s in dbContext.Student
            //               where s.Id == 2
            //               select s).AsNoTracking().FirstOrDefault();
            //Console.WriteLine(student?.Fname ?? "Null");
            //student.Fname = "Mido";
            //Console.WriteLine(student.Fname);
            //dbContext.SaveChanges();

            #endregion
            //course.Name = "algorithm";
            //dbContext.SaveChanges();
            //Console.WriteLine(course.Name);
            #endregion
            #region Delete
            #region Student
            //dbContext.Student.Remove(student);
            //dbContext.SaveChanges(); 
            #endregion
            #region Course
            //dbContext.Course.Remove(course02);
            //dbContext.SaveChanges();
            #endregion
            #endregion
            #endregion
        }
    }
}
