using Assignment.Contexts;
using Assignment.Entities;
using System.Net.Cache;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using itiDbContext DbContext = new itiDbContext();

            #region Student

            #region Add

            //Student student01 = new Student()
            //{
            //    FName = "Mohamed",
            //    Address = "Mansoura",
            //    Age = 21,
            //};
            //Student student02 = new Student()
            //{
            //    FName = "Ali",
            //    Address = "Alex",
            //    Age = 24,
            //};

            //DbContext.Students.Add(student01);
            //DbContext.Students.Add(student02);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var student = (from S in DbContext.Students
            //              where S.Age == 21
            //              select S).FirstOrDefault();

            //Console.WriteLine(student?.FName ?? "NAN"); 
            #endregion

            #region Update

            //var student = (from S in DbContext.Students
            //               where S.Age == 21
            //               select S).FirstOrDefault();
            //student.Address = "Cairo";
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var student = (from S in DbContext.Students
            //               where S.Age == 24
            //               select S).FirstOrDefault();
            //DbContext.Students.Remove(student);
            //DbContext.SaveChanges();

            #endregion

            #endregion

            #region Course

            #region Add

            //Course course01 = new Course()
            //{
            //    Duration = 90,
            //    Name = "course01",
            //    Description = "description01",
            //    Top_ID = 1
            //};
            //Course course02 = new Course()
            //{
            //    Duration = 60,
            //    Name = "course02",
            //    Description = "description02",
            //    Top_ID = 2
            //};

            //DbContext.Courses.Add(course01);
            //DbContext.Courses.Add(course02);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var course = (from C in DbContext.Courses
            //               where C.Duration == 60
            //               select C).FirstOrDefault();

            //Console.WriteLine(course?.Name ?? "NAN");
            #endregion

            #region Update

            //var course = (from C in DbContext.Courses
            //               where C.Duration == 60
            //               select C).FirstOrDefault();
            //course.Duration = 120;
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var course = (from C in DbContext.Courses
            //              where C.Duration == 120
            //              select C).FirstOrDefault();
            //DbContext.Courses.Remove(course);
            //DbContext.SaveChanges();

            #endregion

            #endregion

            #region Stud_Course

            #region Add

            //Stud_Course stud_Course01 = new Stud_Course()
            //{
            //    stud_ID = 1,
            //    Course_ID = 1,
            //    Grade = 'A'
            //};

            //DbContext.Stud_Courses.Add(stud_Course01);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var Stud_Course = (from SC in DbContext.Stud_Courses
            //              where SC.Grade == 'V'
            //              select SC).FirstOrDefault();

            //Console.WriteLine(Stud_Course?.stud_ID ?? 0);
            #endregion

            #region Update

            //var Stud_Course = (from SC in DbContext.Stud_Courses
            //                   where SC.Grade == 'A'
            //                   select SC).FirstOrDefault();
            //Stud_Course.Grade = 75;
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var Stud_Course = (from SC in DbContext.Stud_Courses
            //                   where SC.Grade == 75
            //                   select SC).FirstOrDefault();
            //DbContext.Stud_Courses.Remove(Stud_Course);
            //DbContext.SaveChanges();

            #endregion
            #endregion

            #region Department

            #region Add

            //Department department01 = new Department()
            //{
            //    Name = "department01",
            //    Ins_ID = 1,
            //    HiringDate = DateTime.Now
            //};

            //DbContext.Departments.Add(department01);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var department = (from D in DbContext.Departments
            //                   where D.Name == "department01"
            //                  select D).FirstOrDefault();

            //Console.WriteLine(department?.ID ?? 0);
            #endregion

            #region Update

            //var department = (from D in DbContext.Departments
            //                  where D.Name == "department01"
            //                  select D).FirstOrDefault();

            //department.Name = "department02";
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var department = (from D in DbContext.Departments
            //                  where D.Name == "department02"
            //                  select D).FirstOrDefault();
            //DbContext.Departments.Remove(department);
            //DbContext.SaveChanges();

            #endregion

            #endregion

            #region Topic

            #region Add

            //Topic topic01 = new Topic()
            //{
            //    Name = "topic01"
            //};

            //DbContext.Topics.Add(topic01);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var topic = (from T in DbContext.Topics
            //                  where T.Name == "topic01"
            //                  select T).FirstOrDefault();

            //Console.WriteLine(topic?.ID ?? 0);
            #endregion

            #region Update

            //var topic = (from T in DbContext.Topics
            //             where T.Name == "topic01"
            //             select T).FirstOrDefault();

            //topic.Name = "topic03";
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var topic = (from T in DbContext.Topics
            //             where T.Name == "topic03"
            //             select T).FirstOrDefault();
            //DbContext.Topics.Remove(topic);
            //DbContext.SaveChanges();

            #endregion

            #endregion

            #region Instructor

            #region Add

            //Instructor instructor01 = new Instructor()
            //{
            //    Name = "Omar",
            //    Bouns = 2000,
            //    Salary = 5000,
            //    Address = "Cairo",
            //    HourRate = 200,
            //    Dept_ID = 1
            //};

            //DbContext.Instructors.Add(instructor01);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var ins = (from I in DbContext.Instructors
            //             where I.Name == "Omar"
            //             select I).FirstOrDefault();

            //Console.WriteLine(ins?.ID ?? 0);
            #endregion

            #region Update

            //var ins = (from I in DbContext.Instructors
            //           where I.Name == "Omar"
            //           select I).FirstOrDefault();

            //ins.Address = "Alex";
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var ins = (from I in DbContext.Instructors
            //           where I.Name == "Omar"
            //           select I).FirstOrDefault();

            //DbContext.Instructors.Remove(ins);
            //DbContext.SaveChanges();

            #endregion

            #endregion

            #region Course_Inst

            #region Add

            //Course_Inst course_Inst = new Course_Inst()
            //{
            //    inst_ID = 1,
            //    Course_ID = 1,
            //    evaluate = "Execllent"
            //};

            //DbContext.Course_Insts.Add(course_Inst);
            //DbContext.SaveChanges();
            #endregion

            #region Retrieve [Read]
            //var course_Inst = (from CI in DbContext.Course_Insts
            //           where CI.Course_ID == 1
            //           select CI).FirstOrDefault();

            //Console.WriteLine(course_Inst?.evaluate ?? "NAN");
            #endregion

            #region Update

            //var course_Inst = (from CI in DbContext.Course_Insts
            //                   where CI.Course_ID == 1
            //                   select CI).FirstOrDefault();

            //course_Inst.evaluate = "GOOD";
            //DbContext.SaveChanges();

            #endregion

            #region Delete - Remove

            //var course_Inst = (from CI in DbContext.Course_Insts
            //                   where CI.Course_ID == 1
            //                   select CI).FirstOrDefault();

            //DbContext.Course_Insts.Remove(course_Inst);
            //DbContext.SaveChanges();

            #endregion

            #endregion

        }
    }
}
