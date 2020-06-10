using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    interface ImedidasDeConversion
    {
        //Propiedades
        double Unidad{set; get;}
        string TipoUnidad { set; get; }
        double ResConversion { set; get; }
        string ConvertirNuevo { set; get; }
        //metodos
        void ConvertirNuevoTipo();
    }
}
