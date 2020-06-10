using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchEjercicioAlumnoMaestr
{
    class Persona
    {
        //Atributos de la clase personas
        private string nombre;
        private DateTime fechaNacimiento;
        private string curp;
        private string telefono;
        private string email;

        //Propiedades de la clase para acceder a los atributos privados
        public string Nombre { set { nombre = value; } get { return nombre; } }
        public DateTime FechaNacimiento { set { fechaNacimiento = value; } get { return fechaNacimiento; } }
        public string Curp { set { curp = value; } get { return curp; } }
        public string Telefono { set { telefono = value; } get { return telefono; } }
        public string Email { set { email = value; } get { return email; } }
    }
}
