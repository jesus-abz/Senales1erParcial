using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class EscalonUnitario
    {
        public List<Muestra> Muestras { get; set; }

        public EscalonUnitario()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            if (tiempo >= 0)
            {
                resultado = 1.0;
            }else
            {
                resultado = 0.0;
            }

            return resultado;
        }
    }
}
