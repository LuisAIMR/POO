using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4DatosAlumnosMaestros
{
    class Maestro : Persona
    {
        //Propiedades arreglos de atributoa de la clase maestro
        public int[] NumeroMaes { get; set; }
        public decimal[] Salario { get; set; }
        public string[] MateriasImparte { get; set; }
    }
}
