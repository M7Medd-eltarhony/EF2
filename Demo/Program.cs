using Demo.Contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo02
            //EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //dbContext.Database.Migrate();

            //try
            //{
            //CRUD
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //}

            //using (EnterpriseDbContext dbContext = new EnterpriseDbContext())
            //{
            //    //CRUD
            //}

            //using EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //Employee Emp01 = new Employee()
            //{
            //    Name = "Mohamed",
            //    Salary = 4_000,
            //    Age = 25,
            //    Email = "Mohamed@gmail.com",
            //    Password = "password",
            //    Phonenumber = "12343424"
            //};
            //Employee Emp02 = new Employee()
            //{
            //    Name = "Ali",
            //    Salary = 5_000,
            //    Age = 26,
            //    Email = "Ali@gmail.com",
            //    Password = "password2",
            //    Phonenumber = "12343424"

            //};
            //Console.WriteLine(Emp01.EmpId);
            //Console.WriteLine(Emp02.EmpId);

            #region CRUD Operations
            #region Insert
            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);

            //dbContext.Employees.Add(Emp01);
            //dbContext.Employees.Add(Emp02);
            ////dbContext.Set<Employee>().Add(Emp02);
            ////dbContext.Add(Emp01);
            ////dbContext.Entry(Emp02).State = EntityState.Added;

            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            #endregion

            #region Retrieve [Read]
            //var Employee = (from E in dbContext.Employees
            //               where E.EmpId == 3
            //               select E).FirstOrDefault();

            //Console.WriteLine(Employee?.Name ?? "NAN");
            #endregion

            #region Update
            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 2
            //                select E).FirstOrDefault();

            //Employee.Phonenumber = "2343244";
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State); 
            #endregion

            #region Delete - Remove
            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 2
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.Employees.Remove(Employee);
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            #endregion
            #endregion

            #endregion

            #region Explicit Loading
            //using EnterpriseDbContext DbContext = new EnterpriseDbContext();

            //var Employee = (from E in DbContext.Employees
            //                where E.EmpId == 5
            //                select E).FirstOrDefault();
            //DbContext.Entry(Employee).Reference(E => E.Department).Load();

            //Console.WriteLine($"{Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "NAN"}"); 
            #endregion

            #region Eager Loading
            //using EnterpriseDbContext DbContext = new EnterpriseDbContext();

            //var Employee = (from E in DbContext.Employees.Include(E => E.Department)
            //                where E.EmpId == 5
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "NAN"}");

            #endregion

            #region Lazy Loading
            //using EnterpriseDbContext DbContext = new EnterpriseDbContext();

            //var Employee = (from E in DbContext.Employees
            //                where E.EmpId == 5
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "NAN"}");
            #endregion



        }
    }
}
