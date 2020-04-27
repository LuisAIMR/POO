using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4DatosAlumnosMaestros
{
    class Alumno:Persona
    {
        //arreglos unidimencionales para cada dato
        public int[] NumControl { get; set; }
        public string[] Carrera { get; set; }
        public string[] Materia { get; set; }
        public double[] Calificacion { get; set; }

        public Alumno()
        {
            Alumno[] ArrayAlumno = new Alumno[1000];
        }

    }
}
