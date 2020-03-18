using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
   abstract class Empleado
    {
        private string nombre;
        private string fechaDeNacimiento;
        private int diasTrabajados;
        private double sueldo;

        //propiedades
        public string Nombre
        {
            set {nombre = value;}
            get {return nombre;}
        }
        public string FechadeNacimientos
        {
            set { fechaDeNacimiento = value; }
            get { return fechaDeNacimiento; }
        }
        public int DiasTrabajados
        {
            set { diasTrabajados = value; }
            get { return diasTrabajados; }
        }
        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }
        public Empleado ()
        {
            nombre = "";
            fechaDeNacimiento = "";
            diasTrabajados = 0;
            sueldo = 0;
        }
        public abstract void CalcularSueldo();
        
    }
}
