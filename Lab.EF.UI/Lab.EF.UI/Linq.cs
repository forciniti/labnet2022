using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Linq
    {
        public static int linq(int n)
        {
            CustomersLogic c = new CustomersLogic();
            ProductsLogic p = new ProductsLogic();
            OrdersLogic o = new OrdersLogic();
            CategoryLogic cat = new CategoryLogic();
            var products = p.GetAll();
            var customers = c.GetAll();
            var orders = o.GetAll();
            var categories = cat.GetAll();
            if (n== 1)
            {
                var q1 = from Customers in customers
                         select new
                         {
                             CustomersID=Customers.CustomerID,
                             CustomerName=Customers.CompanyName,
                             CustomerCity=Customers.City
                         };
                foreach (var item in q1)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }
            if (n == 2)
            {
                var q2 = products.Where(x => x.UnitsInStock == 0).Select(x => x.ProductName);
                foreach (var item in q2)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 3)
            {
                var q3 = from Products in products
                         where Products.UnitsInStock == 3 && Products.UnitPrice > 3
                         select Products.ProductName;
                foreach (var item in q3)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 4)
            {
                var q4 = customers.Where(x => x.Region == "WA");
                foreach (var item in q4)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 5)
            {

                var q5 = products.First(x => x.ProductID == 789);
              
                    Console.WriteLine(q5);
                

                return 0;
            }

            if (n == 6)
            {

                var q6 = from Customers in customers
                         select Customers.CompanyName.ToUpper();
                foreach (var item in q6)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 7)
            {
               /* DateTime date = new DateTime(1997, 01, 01, 0, 0, 0);
                var q7 = from Customers in customers
                         join Orders in orders
                         on Customers.Region equals "WA" && DateTime.Compare(Orders.OrderDate, date) < 0
                         select (Customers.CompanyName, Customers.Region, Orders.CustomerID, Orders.OrderDate); ;*/
                return 0;
            }

          
            if (n == 8)
            {
                var q8 = customers.Where(x => x.Region == "WA").Take(3);
                foreach (var item in q8)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 9)
            {
                var q9 = products.OrderBy(x => x.ProductName);
                foreach (var item in q9)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 10)
            {
                var q10 = from Products in products
                          orderby Products.UnitsInStock descending
                          select Products.ProductName;
                foreach (var item in q10)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 11)
            {
                var q11 = from Categories in categories
                          join Products in products
                          on Categories.CategoryID equals Products.CategoryID
                          select Categories.CategoryName;
                foreach (var item in q11)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 12)
            {

                var q12 = products.Select(x => x.ProductID).FirstOrDefault();

                
                    Console.WriteLine(q12);

                return 0;
              
            }

            if (n == 13)
            {
                var q13 = from Customers in customers
                          join Orders in orders
                          on Customers.CustomerID equals Orders.CustomerID
                          select new
                          {
                              Customers = Customers.CompanyName,
                              CantidadOrdenes = Orders.CustomerID.Count()
                          };
                foreach (var item in q13)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
    
            return 0;
        }    
    }
}
