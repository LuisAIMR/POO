using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Mesero:Empleado
    {
        private double propinaSemanal;
        private double sueldoSemanal;


        public double PropinaSemanal
        {
            set { propinaSemanal = value; }
            get { return propinaSemanal; }
        }
        public double SueldoSemanal
        {
            set { sueldoSemanal = value; }
            get { return sueldoSemanal; ; }
        }
        public Mesero()
        {
            propinaSemanal = 0;
        }
        public override void CalcularSueldo()
        {
            SueldoSemanal = (Sueldo* DiasTrabajados) + propinaSemanal;
        }
    }
}
