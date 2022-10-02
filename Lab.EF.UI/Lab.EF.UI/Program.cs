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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter the number  of the query that you want to see ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 14 to EXIT");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 15 to CLEAN THE SCREEN");

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
                Console.Clear();
                Linq.linq(1);

                x = 0;
            }

            if (x == 2)
            {
                Console.Clear();
                Linq.linq(2);

                x = 0;
            }

            if (x == 3)
            {
                Console.Clear();
                Linq.linq(3);

                x = 0;
            }

            if (x == 4)
            {
                Console.Clear();
                Linq.linq(4);

                x = 0;
            }

            if (x == 5)
            {
                Console.Clear();
                Linq.linq(5);

                x = 0;
            }

            if (x == 6)
            {
                Console.Clear();
                Linq.linq(6);

                x = 0;
            }

            if (x == 7)
            {
                Console.Clear();
                Linq.linq(7);

                x = 0;
            }

            if (x == 8)
            {
                Console.Clear();
                Linq.linq(8);

                x = 0;
            }

            if (x == 9)
            {
                Console.Clear();
                Linq.linq(9);

                x = 0;
            }

            if (x == 10)
            {
                Console.Clear();
                Linq.linq(10);

                x = 0;
            }

            if (x == 11)
            {
                Console.Clear();
                Linq.linq(11);

                x = 0;
            }

            if (x == 12)
            {
                Console.Clear();
                Linq.linq(12);

                x = 0;
            }

            if (x == 13)
            {
                Console.Clear();
                Linq.linq(13);

                x = 0;
            }

            if (x == 14)
            {

                Console.Clear();
                x = 14;
            }

            if (x == 15)
            {

                Console.Clear();
                x = 0;
            }

            if (x == 6)
            {

                Console.Clear();
                x = 0;
            }

            if (x > 15)
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