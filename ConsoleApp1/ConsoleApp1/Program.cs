using system;
//efexample
namespace consoleapp1
{
    internal class program
    {
        static day8dbentities db;
        static void main(string[] args)
        {
            try
            {
                db = new day8dbentities();
                foreach (emp e in db.emps)
                {
                    console.writeline("id: " + e.id);
                    console.writeline("firstname: " + e.fname);
                    console.writeline("lastname: " + e.lname);
                    console.writeline("salary: " + e.salary);
                    console.writeline("date of joining:" + e.doj);
                    console.writeline("designation: " + e.designation);
                    console.writeline("");

                }
            }
            catch (exception ex)
            {
                console.writeline(ex.message);

            }
            finally
            {
                console.readkey();
            }
        }
    }
}

//CR
//insert example
//using System;
////EFexample
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static Day8DbEntities db;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day8DbEntities();

//                Emp emp = new Emp();  
//                    Console.WriteLine("Enter ID: ");
//                emp.Id = int.Parse(Console.ReadLine());
//                    Console.WriteLine(" Enter FirstName: ");
//                emp.Fname = Console.ReadLine();
//                    Console.WriteLine("Enter LastName: ");
//                emp.Lname = Console.ReadLine();
//                    Console.WriteLine("Enter Salary: ");
//                emp.Salary = double.Parse(Console.ReadLine());  
//                    Console.WriteLine("Enter Date of Joining:");
//                emp.DOJ = DateTime.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter Designation: ");
//                emp.Designation = Console.ReadLine();
//                db.Emps.Add(emp);
//                db.SaveChanges();
//                Console.WriteLine("Employee Record Inserted!!!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}

//CRU
//using System;
//using System.Linq;
////EFexample
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static Day8DbEntities db;
//        static Emp emp;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day8DbEntities();


//                Console.WriteLine("Enter ID to update the Details ");
//              int id = int.Parse(Console.ReadLine());
//              emp = db.Emps.SingleOrDefault(e => e.Id == id);
//                if (emp == null)
//                {
//                    Console.WriteLine("No such Id " + id + "EXist in Day8Db");
//                }
//                else
//                {
//                    Console.WriteLine(" Enter New FirstName: ");
//                    emp.Fname = Console.ReadLine();
//                    Console.WriteLine("Enter New LastName: ");
//                    emp.Lname = Console.ReadLine();
//                    Console.WriteLine("Enter New Salary: ");
//                    emp.Salary = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter New Date of Joining:");
//                    emp.DOJ = DateTime.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter New Designation: ");
//                    emp.Designation = Console.ReadLine();

//                    db.SaveChanges();
//                    Console.WriteLine("Employee Record Updated!!!");
//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}

//Delete
/*using System;
using System.Linq;
//EFexample
namespace ConsoleApp1
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
                Console.Write("Enter ID to Delete Record: ");
                int id = int.Parse(Console.ReadLine());
                emp = db.Emps.SingleOrDefault(e => e.Id == id);
                if (emp == null)
                {
                    Console.WriteLine("No such Id " + id + "EXist in Day8Db");
                }
                else
                {
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee Record Deleted!!!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}*/
