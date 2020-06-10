using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    interface IPasteleria
    {

        //Propiedades para acceder a los atributos privados de la clase a la que pertenecen
        int CaPostres { set; get; }             
        string Postre { set; get; }
        int Cantidad { set; get; }
        int UnidadDis { set; get; }
    }
}
