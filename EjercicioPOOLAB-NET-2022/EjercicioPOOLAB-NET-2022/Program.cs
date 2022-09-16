using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLAB_NET_2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> list = new List<TransportePublico>();

            //Carga Taxis
            for (int i = 1; i < 6; i++)
            {

                Console.WriteLine("ingrese cantidad pasajeros para el TAXI#" + i);
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 5)
                {
                    list.Add(new Taxi(cantidad));


                }
                else
                {
                    Console.WriteLine("No puede ingresar más de 4 pasajeros al TAXI, ingrese de nuevo el TAXI#" + i);
                    i = i - 1;

                }

            }

            //Carga Omnibus
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("ingrese cantidad pasajeros para el OMNIBUS#" + i);
                int cantidad1 = int.Parse(Console.ReadLine());
                list.Add(new Omnibus(cantidad1));
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("LISTA TRANSPORTES CON CANTIDAD PASAJEROS");
            Console.WriteLine("------------------------------------------------");

            int x = 1;
            //Muestra Lista
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("TRANSPORTE#" + x + list[i].Avanzar());
                x++;
            }

            Console.WriteLine("------------------------------------------------");
            Console.ReadLine();
        }
    }
}
