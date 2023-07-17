using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasString
{
    public static class Assert
    {
        public static void Que(bool condicion)
        {
            if (!condicion)
            {
                throw new Exception("Assertion error");
            }
        }
    }
}
