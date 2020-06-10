using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class ClassTemperatura
    {
        //Atributos de la clase
        public double grado = 0;
        public string tipo;
        public string tipoResultado;
        //Atributos para metodo Fahrenheit
        //public double fahrenheit = 0;
        //Atributos para metodo Celsius
        //public double celsius = 0;

        //Metodos de la clase
        public void ConvCelsius()
        {
            switch(tipo)
            {
                case "°F":
                    {
                        grado=(grado-32)*5/9;
                        tipoResultado = "°C";
                        break;
                    }

            }
        }
        public void convFahrenheit()
        {
            switch(tipo)
            {
                case "°C":
                    {
                        grado = (grado * 9 / 5) + 32;
                        tipoResultado = "°F";
                        break;
                    }
            }

        }

    }
}
