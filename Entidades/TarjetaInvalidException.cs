using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public class TarjetaInvalidException : Exception
    {
        public TarjetaInvalidException(string? message) : base(message)
        {
        }

        public TarjetaInvalidException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
