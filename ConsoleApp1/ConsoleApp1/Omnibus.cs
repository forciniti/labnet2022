using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {

        }
        public override string Avanzar()
        {
            return $" (Omnibus con {pasajeros} pasajeros)";
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
