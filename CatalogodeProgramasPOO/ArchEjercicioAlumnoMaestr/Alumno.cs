using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchEjercicioAlumnoMaestr
{
    class Alumno:Persona
    {
        //Atributos de la clase alumno
        private string numeroControl;
        private string carrera;
        private int cantidadMaterias;

        //Propiedades para acceder a los atributos de la clase alumno
        public string NumeroControl { set { numeroControl = value; } get { return numeroControl; } }
        public string Carrera { set { carrera = value; } get { return carrera; } }
        public int CantidadMaterias { set { cantidadMaterias = value; } get { return cantidadMaterias; } }
        //Arreglo bidimencional de atributos
        public string[] Materias { set; get; }
        public double[] Calificacion { set; get; }

        public Alumno()
        {
            string[] Materias = new string[1000];
        }
        public string MostrarDatos()
        {

            string Mensaje;
            Mensaje = "";
            for (int i = 0; i < cantidadMaterias; i++)
            {
                Mensaje += "\n Materia :" + Materias[i];
                Mensaje += "\n Calificacion" + Calificacion[i];
            }




            return Mensaje;
        }
    }
}
