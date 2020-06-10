using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Vehiculo
    {

        //Atributos de la clase
        public string tipoDeCombustible;
        public string color;
        public int numeroLlantas;
        public int numeroPuertas;
        public int NumeroVentanas;
        public string sonidoArrancar, sonidoParar;

        //Constructor de la clase
        public Vehiculo()
        {
            tipoDeCombustible = "";
            color = "Blanco";
            numeroLlantas = 1;
            numeroPuertas = 0;
            NumeroVentanas = 0;
            sonidoArrancar = "";
            sonidoParar = "";
        }

        //Metodos de la clase
        public string arrancarMotor()
        {
            return "Se arranco el motor " + sonidoArrancar;
        }
        public string pararMotor()
        {
            return "Se paro el motor " + sonidoParar;
        }

    }
}
