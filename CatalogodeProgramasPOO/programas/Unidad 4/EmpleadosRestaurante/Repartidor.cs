using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Repartidor:Empleado
    {
        private double propinaSemanal;
        private int zonaDeReparto;
        private int pedidosRealizados;
        private double sueldoSemanal;

        public double PropinaSemanal
        {
            set { propinaSemanal = value; }
            get { return propinaSemanal; }
        }
        public int ZonaDeReparto
        {
            set { zonaDeReparto = value; }
            get { return zonaDeReparto; }
        }
        public int PedidosRealizados
        {
            set { pedidosRealizados = value; }
            get { return pedidosRealizados; }
        }
        public double SueldoSemanal
        {
            set { sueldoSemanal = value; }
            get { return sueldoSemanal; }
        }
        public Repartidor()
        {
            propinaSemanal = 0;
            zonaDeReparto = 0;
            PedidosRealizados = 0;
            sueldoSemanal = 0;
        }
        
        public override void CalcularSueldo()
        {   
            if(ZonaDeReparto==1)
            {
                SueldoSemanal = (Sueldo *DiasTrabajados) +(PedidosRealizados* 5);
            }
            else if(ZonaDeReparto==2)
            {
                SueldoSemanal =(Sueldo* DiasTrabajados) + (PedidosRealizados*2);
            }
        }
    }
}
