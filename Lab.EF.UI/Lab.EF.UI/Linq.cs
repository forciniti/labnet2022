using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Linq
    {
        public Linq()
        {
            CustomersLogic c = new CustomersLogic();
            ProductsLogic p = new ProductsLogic();
            OrdersLogic o = new OrdersLogic();
            var products = p.GetAll();
            var customers = c.GetAll();
            var orders = o.GetAll();
            var q1 = from Customers in customers
                         select Customers;
            var q2 = from Products in products
                         where Products.UnitsInStock == 0
                         select Products.ProductName;

            var q3 = from Products in products
                         where Products.UnitsInStock == 3 && Products.UnitPrice > 3
                         select Products.ProductName;
            var q4 = customers.Where(x => x.Region == "WA");

            var q5 = products.First(x => x.ProductID == 789);

            var q6 = customers.Select(x => x.ContactName);
            var q7 = customers.Where(x => x.Region == "WA").Union(orders.Where(x => x.OrderDate > ))
        }
    /*    public void query1()
        {
            CustomersLogic c = new CustomersLogic();
            var customers = c.GetAll();
            var q1 = from Customers in customers
                         select Customers;
        }
        public void query2()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query3()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query4()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query5()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query6()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query7()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query8()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query9()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query10()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query11()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query12()
        {
            foreach (var item in collection)
            {

            }
        }

        public void query13()
        {
            foreach (var item in collection)
            {

            }
        }
    */

    }
}
