using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)

        {

        }

        public override string Avanzar()
        {
            return $" (Taxi con {pasajeros} pasajeros)";
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
