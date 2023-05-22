using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTestUnitarios
{
    public class CadenaException : Exception
    {
        public CadenaException(string mensaje) : base(mensaje)
        {

        }
    }
}
