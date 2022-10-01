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