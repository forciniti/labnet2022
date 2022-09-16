using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOLAB_NET_2022
{
    public class Taxi : TransportePublico
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
