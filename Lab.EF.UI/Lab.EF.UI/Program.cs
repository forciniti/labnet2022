using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
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
            int r = 1;


            for (int i = 0; i < r; i++)
            {
                if (x == 0)
                {
                    x = IngresoDatos(x);
                    r++;
                }
                else
                {
                    r = 0;
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
            Console.WriteLine("Enter 1 to view list of suppliers and shippers list");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 2 to ADD a new record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 3 to DELETE a record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 4 to UPDATE a record to Shippers");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 5 to EXIT");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 6 to CLEAN THE SCREEN");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Enter a valid option please!");
                Console.WriteLine("");
                x = 0;
            }

            if (x < 0)
            {
                Console.Clear();
                Console.WriteLine("Enter a valid option please!");
                Console.WriteLine("");
                x = 0;
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
                    Console.WriteLine($"(id){item.ShipperID} - (SupplierName){item.CompanyName} - (PhoneNumber){item.Phone}");
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
                x = 0;
            }

            if (x == 3)
            {
                Console.Clear();

                Console.WriteLine("Enter a Shipper´s ID to DELETE");
                try
                {
                    int y = int.Parse(Console.ReadLine());
                    if (y > 0)
                    {
                        shl.Delete(y);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Enter a valid ID to DELETE please!");
                        Console.WriteLine("");
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.Clear();
                    Console.WriteLine("Enter an EXISTENT ID to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Enter an integer value to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }
                catch (Exception )
                {

                    Console.Clear();
                    Console.WriteLine("Enter a valid ID to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }


                x = 0;
            }

            if (x == 4)
            {
                Console.Clear();
                Console.WriteLine("Enter a Shipper's ID to UPDATE");
                try
                {
                    int y = int.Parse(Console.ReadLine());
                    if (y > 0)
                    {
                        Console.WriteLine("Enter a new CompanyName");
                        string w = "";
                        w = Console.ReadLine();
                        foreach (var item  in shippers)
                        {
                            if(item.ShipperID == y)
                            {
                                shl.Update(new Shippers
                                {
                                    CompanyName = w,
                                    ShipperID = y
                                }
                                         );
                                
                                return x=0;
                            }

                        }
                            Console.Clear();
                            Console.WriteLine(" INEXISTENT ID please enter another ID to DELETE!");
                            Console.WriteLine("");
                            x = 0;

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Enter a valid ID to UPDATE please!");
                        Console.WriteLine("");
                    }
                }
                catch (NullReferenceException)
                {
                    Console.Clear();
                    Console.WriteLine("Enter an EXISTENT ID to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }
                catch (ArgumentNullException)
                {
                    Console.Clear();
                    Console.WriteLine("Enter an EXISTENT ID to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Enter an integer ID value to DELETE please!");
                    Console.WriteLine("");
                    x = 0;
                }

                catch (Exception )
                {
                    Console.Clear();
                    Console.WriteLine("Enter valids parameters to UPDATE please!");
                    x = 0;
                }

                x = 0;
            }
            if (x == 5)
            {

                Console.Clear();
                x = 5;
            }

            if (x == 6)
            {

                Console.Clear();
                x = 0;
            }
            if (x > 6)
            {

                Console.Clear();
                Console.Clear();
                Console.WriteLine("Enter an EXISTENT OPTION please!");
                Console.WriteLine("");
                x = 0;
            }
            return x;
        }

    }


}