using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public  interface IProducto<T>
    {
         public bool QuitarProducto(List <T> producto, string nombre);
    }
}
