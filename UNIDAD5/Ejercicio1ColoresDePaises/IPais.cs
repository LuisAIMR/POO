using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1ColoresDePaises
{
    interface IPais
    {
        /*Se utilizan las propiedades para poder acceder
        a los datos de las clases en las que se van a utilizar*/
        string NombrePais { get; set; }
        decimal TotalPoblacion { get; set; }
        string IdiomaPredominante { get; set; }
    }
}
