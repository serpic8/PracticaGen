using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjSueldo_Clases_Forms_
{
    public class Nomina
    {
        private int diasLaborados;
        public int DiasLaborados { get; set; }

        //Metodo para calcular nomina
        public double TotalDevengado(int dias,double salarioDia)
        {
            double total = dias * salarioDia;
            return total;
        }
    }
}
