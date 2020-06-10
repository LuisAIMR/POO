using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchNpaises
{
    class Pais
    {
        //atributos de la clase pais
        private string nombrePais;
        private decimal totalPoblacion;
        private string idiomaPredominante;

        //propiedades de la clase pais
        public string NombrePais { get { return nombrePais; } set { nombrePais = value; } }
        public decimal TotalPoblacion { get { return totalPoblacion; } set { totalPoblacion = value; } }
        public string IdiomaPredominante { get { return idiomaPredominante; } set { idiomaPredominante = value; } }
        //Arreglo de atributos
        public string[] ColoresBandera;
        //Arreglo de objetos


        //constructor de la clase pais
        public Pais()
        {
            NombrePais = "";
            TotalPoblacion = 0;
            IdiomaPredominante = "";
            ColoresBandera = new string[3];

        }
    }
}
