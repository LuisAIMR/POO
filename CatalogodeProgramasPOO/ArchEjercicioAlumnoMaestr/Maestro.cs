using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchEjercicioAlumnoMaestr
{
    class Maestro:Persona
    {
        //Atributos de la clase alumno
        private string numeroMaestro;
        private decimal salario;
        //Arreglo bidimencional de atributos
        public string[] MateriasImp;

        //Propiedades para acceder a los atributos de la clase alumno
        public string NumreroMaestro { set { numeroMaestro = value; } get { return numeroMaestro; } }
        public decimal Salario { set { salario = value; } get { return salario; } }
    }
}
