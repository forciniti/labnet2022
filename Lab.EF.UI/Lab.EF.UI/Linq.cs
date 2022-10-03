using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

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
                             ID = Customers.CustomerID,
                             NAME = Customers.CompanyName,
                             CITY = Customers.City
                         };

                foreach (var item in q1)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }
            if (n == 2)
            {
                var q2 = products.Where(x => x.UnitsInStock == 0).Select(x => new { PRODUCTNAME = x.ProductName, STOCK =  x.UnitsInStock });

                foreach (var item in q2)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 3)
            {
                var q3 = from Products in products
                         where Products.UnitsInStock > 0 && Products.UnitPrice > 3
                         select new
                         {
                             PRODUCTNAME = Products.ProductName,
                             STOCK = Products.UnitsInStock,
                             PRICE = Products.UnitPrice
                         };

                foreach (var item in q3)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 4)
            {
                var q4 = customers.Where(x => x.Region == "WA")
                                  .Select(x => new{ CUSTOMERNAME = x.CompanyName, REGION = x.Region });

                foreach (var item in q4)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 5)
            {

                var q5 = products.FirstOrDefault(x => x.ProductID == 789);    
                    Console.WriteLine(q5);
                

                return 0;
            }

            if (n == 6)
            {

                var q6M = from Customers in customers
                         select Customers.CompanyName.ToUpper();

                var q6m = from Customers in customers
                select Customers.CompanyName.ToLower();

                Console.WriteLine("WITH UPPERCASE LETTER ");
                Console.WriteLine("");
                foreach (var item in q6M)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("WITH LOWERCASE LETTER ");
                Console.WriteLine("");

                foreach (var item in q6m)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 7)
            {

                DateTime date = new DateTime(1997, 01, 01, 0, 0, 0);
                var q7 = from Customers in customers
                         join Orders in orders
                         on Customers.Region equals "WA"
                         where Orders.OrderDate > date
                         select new { CUSTOMER_NAME = Customers.CompanyName, REGION = Customers.Region, ORDERID = Orders.CustomerID, ORDER_DATE = Orders.OrderDate };    
                
                foreach (var item in q7)
                {
                    Console.WriteLine(item);
                }
                return 0;
            }

          
            if (n == 8)
            {
                var q8 = customers.Where(x => x.Region == "WA").Select(x => new {CUSTOMERNAME = x.CompanyName, REGION = x.Region}).Take(3);

                foreach (var item in q8)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 9)
            {
                var q9 = products.OrderBy(x => x.ProductName).Select(x => new {PRODUCTNAME = x.ProductName, PRECIO = x.UnitPrice });

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
                          select new
                          {
                             PRODUCTNAME = Products.ProductName,
                             STOCK = Products.UnitsInStock
                          };

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
                          select new
                          {
                              CATEGORY = Categories.CategoryName,
                              PRODUCTNAME = Products.ProductName
                          };

                foreach (var item in q11)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (n == 12)
            {

                var q12 = products.Select(x => new { ID = x.ProductID, PRODUCTNAME = x.ProductName }).FirstOrDefault();

                
                    Console.WriteLine(q12);

                return 0;
              
            }

            if (n == 13)
            {
                var q13 = from Orders in orders
                          join Customers in customers
                          on Orders.CustomerID equals Customers.CustomerID
                          group Orders by new { Orders.CustomerID, Customers.CompanyName }
                          into g
                          orderby g.Key.CompanyName
                           
                select new
                            {
                                CUSTOMER_ID = g.Key.CustomerID,
                                CUSTOMER_ID2 = g.Key.CompanyName,
                                ASSOCIATED_ORDERS = g.Count()
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
