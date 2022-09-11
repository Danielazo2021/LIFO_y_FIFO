using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ejercicio2_1_Pilas.Datos.Interface
{
     interface IDao
    {
       

        bool estaVacia(string pa);
        bool extrae(string pa);
        bool añadir (string oElemento, string pa);
        DataTable primerElemento(string pa);

    }
}
