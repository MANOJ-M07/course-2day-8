using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment8
{
    public class Products
    {
        static AdvancedDBEntities db;
        public void ReadProductDetails()
        {
            try
            {
                db = new AdvancedDBEntities();
                foreach (Product pro in db.Products)
                {
                    Console.WriteLine("ID: " + pro.ProductId);
                    Console.WriteLine("Product Name: " + pro.ProductName);
                    Console.WriteLine("Description: " + pro.Description);
                    Console.WriteLine("Price: " + pro.price);
                    Console.WriteLine("Release Date: " + pro.ReleaseDate);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void insertProductDetails()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID: ");
                Product.ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name: ");
                Product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Product Description: ");
                Product.Description = Console.ReadLine();
                Console.WriteLine("Enter Product Price: ");
                Product.price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Release date: ");
                Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                db.Products.Add(Product);
                db.SaveChanges();

                Console.WriteLine("Product Record Inserted");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void updateProductDetails()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.ProductId == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    Console.WriteLine("Enter Product Name: ");
                    Product.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Description: ");
                    Product.Description = Console.ReadLine();
                    Console.WriteLine("Enter Product Price: ");
                    Product.price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Release date: ");
                    Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Product Record Updated");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        public void deleteProductDetails()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.ProductId == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    db.Products.Remove(Product);
                    db.SaveChanges();

                    Console.WriteLine("Product Record Deleted");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}