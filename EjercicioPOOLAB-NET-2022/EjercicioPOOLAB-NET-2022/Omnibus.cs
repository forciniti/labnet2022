using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLAB_NET_2022
{
    public class Omnibus : TransportePublico
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
