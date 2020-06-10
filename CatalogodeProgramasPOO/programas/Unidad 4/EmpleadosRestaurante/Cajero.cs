using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Cajero:Empleado
    {
        private int numCaja;
        private double sueldoSemanal;

        public int NumCaja
        {
            set { numCaja = value; }
            get { return numCaja; }
        }
        public double SueldoSemanal
        {
            set {sueldoSemanal=value; }
            get { return sueldoSemanal; }
        }
        public Cajero()
        {
            numCaja = 0;
            sueldoSemanal = 0;
        }
        public override void CalcularSueldo()
        {
            if(NumCaja==2)
            {
                SueldoSemanal = (Sueldo * DiasTrabajados);
                sueldoSemanal = sueldoSemanal + (sueldoSemanal * .3);
            }
            else if (numCaja==1)
            {
                SueldoSemanal = Sueldo * DiasTrabajados;

            }
           
        }
    }
}
