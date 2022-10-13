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
           
            int opcion;
            opcion = 0;
            int r = 1;


            for (int i = 0; i < r; i++)
            {
                if (opcion == 0)
                {
                    opcion = IngresoDatos(opcion);
                    r++;
                }
                else
                {
                    r = 0;
                }
            }
        }
        public static int IngresoDatos(int opcion)
        {
            LinqLogic linqLogic = new LinqLogic();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter the number  of  query that you want to see ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 14 to EXIT");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter 15 to CLEAN THE SCREEN");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Enter a valid option please!");
                Console.WriteLine("");
               opcion = 0;
            }

            if (opcion < 0)
            {
                Console.Clear();
                Console.WriteLine("Enter a valid option please!");
                Console.WriteLine("");
                opcion = 0;
            }

            if (opcion == 1)
            {
                Console.Clear();
                linqLogic.Linq(1);

                opcion = 0;
            }

            if (opcion == 2)
            {
                Console.Clear();
                linqLogic.Linq(2);

                opcion = 0;
            }

            if (opcion == 3)
            {
                Console.Clear();
                linqLogic.Linq(3);

                opcion = 0;
            }

            if (opcion == 4)
            {
                Console.Clear();
                linqLogic.Linq(4);

                opcion = 0;
            }

            if (opcion == 5)
            {
                Console.Clear();
                linqLogic.Linq(5);

                opcion = 0;
            }

            if (opcion == 6)
            {
                Console.Clear();

                linqLogic.Linq(6);
                opcion = 0;
            }

            if (opcion == 7)
            {
                Console.Clear();
                linqLogic.Linq(7);

                opcion = 0;
            }

            if (opcion == 8)
            {
                Console.Clear();
                linqLogic.Linq(8);

                opcion = 0;
            }

            if (opcion == 9)
            {
                Console.Clear();
                linqLogic.Linq(9);

                opcion = 0;
            }

            if (opcion == 10)
            {
                Console.Clear();
                linqLogic.Linq(10);

                opcion = 0;
            }

            if (opcion == 11)
            {
                Console.Clear();
                linqLogic.Linq(11);

                opcion = 0;
            }

            if (opcion == 12)
            {
                Console.Clear();
                linqLogic.Linq(12);

                opcion = 0;
            }

            if (opcion == 13)
            {
                Console.Clear();
                linqLogic.Linq(13);

                opcion = 0;
            }

            if (opcion == 14)
            {

                Console.Clear();
               opcion = 14;
            }
          if  (opcion == 15)
            {

                Console.Clear();
               opcion = 0;
            }

            if (opcion > 15)
            {

                Console.Clear();
                Console.Clear();
                Console.WriteLine("Enter an EXISTENT OPTION please!");
                Console.WriteLine("");
                opcion = 0;
            }
            return opcion;
        }

    }


}