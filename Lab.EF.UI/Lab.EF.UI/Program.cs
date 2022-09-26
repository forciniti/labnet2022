using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
             SuppliersLogic sl = new SuppliersLogic();
             ShippersLogic shl = new ShippersLogic();
             var suppliers = sl.GetAll();
             var shippers = shl.GetAll();
         //   ILogic<Suppliers> sl = new SuppliersLogic();
      //      ILogic<Shippers> shl = new ShippersLogic();

            foreach (var item in suppliers)
            {
                Console.WriteLine($"{item.SupplierID} - (SupplierName){item.CompanyName} - (ContactName){item.ContactName} - (ContactTitle){item.ContactTitle} - (Adreess, city){item.Address}, {item.City}");
            }

            Console.WriteLine("---------------------------------------------------------");

            foreach (var item in shippers)
            {
                Console.WriteLine($"{item.ShipperID} - (SupplierName){item.CompanyName} - (ContactName){item.Phone}");
            }

            Console.ReadKey();

        }


    }
}
