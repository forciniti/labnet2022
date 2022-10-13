using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class LinqLogic : BaseLogic
    {
        public  int Linq(int opt)
        {
            if (opt == 1)
            {
                var q1 = from Customers in _context.Customers
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
            if (opt == 2)
            {
                var q2 = _context.Products.Where(x => x.UnitsInStock == 0).Select(x => new { PRODUCTNAME = x.ProductName, STOCK = x.UnitsInStock });

                foreach (var item in q2)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (opt== 3)
            {
                var q3 = from Products in _context.Products
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

            if (opt == 4)
            {
                var q4 = _context.Customers.Where(x => x.Region == "WA")
                                  .Select(x => new { CUSTOMERNAME = x.CompanyName, REGION = x.Region });

                foreach (var item in q4)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (opt == 5)
            {

                var q5 = _context.Products.FirstOrDefault(x => x.ProductID == 789);
                Console.WriteLine(q5);


                return 0;
            }

            if (opt == 6)
            {

                var q6M = from Customers in _context.Customers
                          select Customers.CompanyName.ToUpper();

                var q6m = from Customers in _context.Customers
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

            if (opt == 7)
            {

                DateTime date = new DateTime(1997, 01, 01, 0, 0, 0);
                var q7 = from Customers in _context.Customers
                         join Orders in _context.Orders
                         on Customers.Region equals "WA"
                         where Orders.OrderDate > date
                         select new { CUSTOMER_NAME = Customers.CompanyName, REGION = Customers.Region, ORDERID = Orders.CustomerID, ORDER_DATE = Orders.OrderDate };

                foreach (var item in q7)
                {
                    Console.WriteLine(item);
                }
                return 0;
            }


            if (opt == 8)
            {
                var q8 = _context.Customers.Where(x => x.Region == "WA").Select(x => new { CUSTOMERNAME = x.CompanyName, REGION = x.Region }).Take(3);

                foreach (var item in q8)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (opt == 9)
            {
                var q9 = _context.Products.OrderBy(x => x.ProductName).Select(x => new { PRODUCTNAME = x.ProductName, PRECIO = x.UnitPrice });

                foreach (var item in q9)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

            if (opt == 10)
            {
                var q10 = from Products in _context.Products
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

            if (opt == 11)
            {
                var q11 = from Categories in _context.Categories
                          join Products in _context.Products
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

            if (opt == 12)
            {

                var q12 = _context.Products.Select(x => new { ID = x.ProductID, PRODUCTNAME = x.ProductName }).FirstOrDefault();


                Console.WriteLine(q12);

                return 0;

            }

            if (opt == 13)
            {
                var q13 = from Orders in _context.Orders
                          join Customers in _context.Customers
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
                return 0;
            }
            Console.ReadKey();

            return 0;
        }
    }
}
