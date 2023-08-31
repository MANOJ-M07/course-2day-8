/*//display
using System;


namespace EFExampleOne
{
    internal class Program
    {
        static Day8DbEntities db;
        static void Main(string[] args)
        {
            try
            {
                db = new Day8DbEntities();
                foreach(Emp e in db.Emps)
                {
                    Console.WriteLine("ID:"+e.Id);
                    Console.WriteLine("First Name:"+e.Fname);
                    Console.WriteLine("Last Name:"+e.Lname);
                    Console.WriteLine("Salary:"+e.Salary);
                    Console.WriteLine("Date of Joining:"+e.DOJ);
                    Console.WriteLine("Designation:"+e.Designation);
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/

//insert example
/*using System;


namespace EFExampleOne
{
    internal class Program
    {
        static Day8DbEntities db;
        static void Main(string[] args)
        {
            try
            {
                db = new Day8DbEntities();
                Emp emp = new Emp();
                Console.WriteLine("Enter the ID:");
                emp.Id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the First Name:");
                emp.Fname=Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                emp.Lname=Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                emp.Salary=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date of Joining:");
                emp.DOJ=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Designation:");
                emp.Designation=Console.ReadLine();
                db.Emps.Add(emp);
                db.SaveChanges();
                Console.WriteLine("Employee Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/

//CRU-search,Update,Read
/*using System;
using System.Linq;

namespace EFExampleOne
{
    internal class Program
    {
        static Day8DbEntities db;
        static Emp emp;
        static void Main(string[] args)
        {
            try
            {
                db = new Day8DbEntities();
                Console.WriteLine("Enter id to update the details");
                int id = int.Parse(Console.ReadLine());
                emp = db.Emps.SingleOrDefault(e=>e.Id==id);
                if (emp == null)
                {
                    Console.WriteLine("no such id"+id+"exist in Day8Db");
                }
                else
                {
                    Console.WriteLine("Enter the New First Name:");
                    emp.Fname = Console.ReadLine();
                    Console.WriteLine("Enter New Last Name");
                    emp.Lname = Console.ReadLine();
                    Console.WriteLine("Enter New Salary:");
                    emp.Salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Date of Joining:");
                    emp.DOJ = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Designation:");
                    emp.Designation = Console.ReadLine();
                    db.SaveChanges();
                    Console.WriteLine("Employee record Updated");
                }
                
                Console.WriteLine("Employee Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/

//delete
using System;
using System.Linq;

namespace EFExampleOne
{
    internal class Program
    {
        static Day8DbEntities db;
        static Emp emp;
        static void Main(string[] args)
        {
            try
            {
                db = new Day8DbEntities();
                Console.WriteLine("Enter id to delete");
                int id = int.Parse(Console.ReadLine());
                emp = db.Emps.SingleOrDefault(e => e.Id == id);
                if (emp == null)
                {
                    Console.WriteLine("no such id" + id + "exist in Day8Db");
                }
                else
                {
                   db.Emps.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee record deleted");
                }

                Console.WriteLine("Employee Record Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}