using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace segundo_herencia
{
    class CLIENTE_CORPORATIVO:CLIENTE
    {
        double cuenta;

        public double Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public void pago()
        { }

        

        

    }
}
