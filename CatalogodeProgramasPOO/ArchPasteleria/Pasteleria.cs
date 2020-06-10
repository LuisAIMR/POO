using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchPasteleria
{
    class Pasteleria
    {
        //Se crea un array y de indica con una comilla que sea multidimencional
        //public string[,] mPostres;

        //-------------

        //se crean los atributos 
        //atributo para la cantidad de postres
        private int caPostres;

        //atributos para asginar valores dependiendo del postre elegido
        private string postre;
        private int cantidad;
        private int unidadDis;

        //Constructor de la clase
        public Pasteleria()
        {

            caPostres = 0;

            postre = "";
            cantidad = 0;
            unidadDis = 0;
        }
        public string[,] mPostres;
        public int CaPostres { set { caPostres = value; } get { return caPostres; } }
        public string Postre { set { postre = value; } get { return postre; } }
        public int Cantidad { set { cantidad = value; } get { return cantidad; } }
        public int UnidadDis { set { unidadDis = value; } get { return unidadDis; } }
    }
}
