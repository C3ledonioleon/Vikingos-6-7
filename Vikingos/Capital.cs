using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos
{
        public class Capital : Lugar
        {
            public int Defensores { get; set; }
            public double FactorRiqueza { get; set; }

            public Capital(int defensores, double factorRiqueza)
            {
                Defensores = defensores;
                FactorRiqueza = factorRiqueza;
            }

            public override int ObtenerBotin(int cantidadVikingos)
            {
                int derrotados = Math.Min(cantidadVikingos, Defensores);
                return (int)(derrotados * FactorRiqueza);
            }

            public override bool ValeLaPena(int cantidadVikingos)
            {
                int botin = ObtenerBotin(cantidadVikingos);
                return botin >= cantidadVikingos * 3;
            }
        }
}