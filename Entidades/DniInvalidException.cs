using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public class DniInvalidException:Exception
    {
        public DniInvalidException(string mensaje) : base(mensaje) 
        { 
        
        }
        public DniInvalidException(string mensaje, Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
