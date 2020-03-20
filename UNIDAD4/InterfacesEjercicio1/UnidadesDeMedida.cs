using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    abstract class unidadesDeMedida:ImedidasDeConversion
    {
        //El atributo de unidad nos sirve para introducir el valor dependiendo del tipo de unidad de medida
        private double unidad;
        //El atributo de tipoUnidad es donde almacenamos el la unidad introducida para el tipo de unidad seleaccionada
        private string tipoUnidad;
        //El atributo convertirNuevo sirve para determinar hacia que nueva medida vamos a convetir el dato actual
        private string convertirNuevo;
        //El atributo de resConversion sirve para almacenar el resultado de la conversion a lanueva unidad de medida
        private double resConversion;
        //La propiedad Unidad es para acceder al atributo privada unidad 
        public double Unidad { set { unidad=value; } get { return unidad; } }
        //La propiedad Unidad es para acceder al atributo privada unidad
        public string TipoUnidad { set { tipoUnidad = value; } get { return tipoUnidad; } }
        //La propiedad ResConversion es para acceder al atributo privada resConversion
        public double ResConversion { set { resConversion = value; } get { return resConversion;} }
        //La propiedad ConvertirConversion es para acceder al atributo privada convertirNuevo
        public string ConvertirNuevo { set { convertirNuevo = value; } get { return convertirNuevo; } }
        //El constructor UnidadesMeMedida es donde colocamos el valor a los atributos
        public unidadesDeMedida()
        {
            unidad = 0;
            tipoUnidad="";
            resConversion = 0;
        }
        //El metodo ConvertirNuevoTipo es para convertir el tipo de unidad de medida introducida al nuevo tipo de unidad que deseemos convertir
        public abstract void ConvertirNuevoTipo();
        
    }
}
