using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Program
    {
        static void Main(string[] args)
        {

            int x;
            x = 0;
            int r=1;


            for (int i = 0; i < r; i++)
            {
                if (x==0)
                {
                  x= IngresoDatos(x);
                    r++;
                }
                else
                {
                       r=0;                  
                }
            }
        }
        public static int IngresoDatos(int x)
        {
            SuppliersLogic sl = new SuppliersLogic();
            ShippersLogic shl = new ShippersLogic();
            var suppliers = sl.GetAll();
            var shippers = shl.GetAll();
            Console.WriteLine(""); 
            Console.WriteLine("");
            Console.WriteLine("press 1 to view list of suppliers and shippers list");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("press 2 to ADD a new record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("press 3 to DELETE a record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("press 4 to UPDATE a record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("press 5 to EXIT");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }

            if (x == 1)
            {
                foreach (var item in suppliers)
                {
                    Console.WriteLine($"(id){item.SupplierID} - (SupplierName){item.CompanyName} - (ContactName){item.ContactName} - (Adreess, city){item.Address}, {item.City}");
                }

                Console.WriteLine("---------------------------------------------------------");

                foreach (var item in shippers)
                {
                    Console.WriteLine($"(id){item.ShipperID} - (SupplierName){item.CompanyName} - (ContactName){item.Phone}");
                }
                x = 0;
            }
            if (x == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter a CompanyName");
                string w = "";
                w = Console.ReadLine();

                shl.Add(new Shippers
                {
                    CompanyName = w
                }
                      );
                x=0;
            }

            if (x == 3)
            {
                Console.Clear();

                Console.WriteLine("Enter a Shipper´s ID to DELETE");
                shl.Delete(int.Parse(Console.ReadLine()));
                x = 0;
            }

            if (x == 4)
            {
                Console.Clear();
                Console.WriteLine("Enter a Shipper's ID to DELETE");
                int y=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a new CompanyName");
                string w = "";
                w = Console.ReadLine();

                shl.Update(new Shippers
                {
                    ShipperID=y,
                    CompanyName = w
                }
                          );
                x = 0;
            }
            if (x==5)
            {

                Console.Clear();
                x = 5;
            }

            return x;
        }

    }


}
