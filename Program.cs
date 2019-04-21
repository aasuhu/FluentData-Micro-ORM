using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentData;

namespace FluentDBDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            IDbContext Context = DBContext.Context();

            //--------------     Insert data -----------------------
            //Using SQL:
            //int productId = Context.Sql(@"INSERT INTO Product(Name, CategoryId) VALUES(@0, @1);")
            //    .Parameters("T-Mobile", 1)
            //    .ExecuteReturnLastId<int>();

            //Using a builder:
            //int productId = Context.Insert("Product")
            //    .Column("Name", "The Warren Buffet Way")
            //    .Column("CategoryId", 1)
            //    .ExecuteReturnLastId<int>();


            //if (productId > 0)
            //{
            //    Console.WriteLine("Record save successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Operation failed");
            //}
            //Console.ReadLine();


            //Using a builder with automapping:

            //Product product = new Product();
            //product.Name = "IOS";
            //product.CategoryId = 1;
            //product.ProductId = Context.Insert<Product>("Product", product)
            //    .AutoMap(x => x.ProductId)
            //    .ExecuteReturnLastId<int>();

            //if (product.ProductId > 0)
            //{
            //    Console.WriteLine("Record save successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Operation failed");
            //}
            //Console.ReadLine();



            //--------------     Update data -----------------------
            //Using SQL:
            //int rowsAffected = Context.Sql(@"UPDATE Product SET Name = @0 WHERE ProductId = @1")
            //    .Parameters("IOS- Updated", 9)
            //    .Execute();



            //    Using a builder:
            //int rowsAffected = Context.Update("Product")
            //    .Column("Name", "The Warren Buffet Way")
            //    .Where("ProductId", 1)
            //    .Execute();

            //    Using a builder with automapping:
            //Product product = Context.Sql(@"SELECT * FROM Product WHERE ProductId = 9")
            //    .QuerySingle<Product>();
            //product.Name = "IOS updated 1";

            //int rowsAffected = Context.Update<Product>("Product", product)
            //    .AutoMap(x => x.ProductId)
            //    .Where(x => x.ProductId)
            //    .Execute();

            //if (rowsAffected > 0)
            //{
            //    Console.WriteLine("Record update successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Operation failed");
            //}
            //Console.ReadLine();





            //--------------     Delete data -----------------------
            //Using SQL:
            //int rowsAffected = Context.Sql(@"DELETE FROM Product WHERE ProductId = 1")
            //    .Execute();
          
            //      Using a builder:
            int rowsAffected = Context.Delete("Product")
                .Where("ProductId", 9)
                .Execute();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record Delete successfully");
            }
            else
            {
                Console.WriteLine("Operation failed");
            }
            Console.ReadLine();
        }
    }
}













//--------------      Query for list of items-----------------------

// Return a list of dynamic objects(new in .NET 4.0):
//List<dynamic> products = Context.Sql(@"SELECT * FROM Product").QueryMany<dynamic>();

// Return a list of strongly typed objects:
//  List<Product> products = Context.Sql(@"SELECT * FROM Product").QueryMany<Product>();

//  Return a list of strongly typed objects in a custom collection:
// ProductionCollection products = Context.Sql(@"SELECT * FROM Product").QueryMany<Product, ProductionCollection>();


//--------------      Query for a single item -----------------------
//Return as a dynamic object:
//dynamic product = Context.Sql(@"SELECT * FROM Product WHERE ProductId = 1").QuerySingle<dynamic>();
//    Return as a strongly typed object:
//    Product product = Context.Sql(@"SELECT * FROM Product WHERE ProductId = 1").QuerySingle<Product>();
//Return as a DataTable:
//DataTable products = Context.Sql(@"SELECT * FROM Product").QuerySingle<DataTable>();


//--------------      Query for a scalar value -----------------------
//int numberOfProducts = Context.Sql(@"SELECT COUNT(*) FROM Product").QuerySingle<int>();
//  Query for a list of scalar values
//List<int> productIds = Context.Sql(@"SELECT ProductId FROM Product").QueryMany<int>();





