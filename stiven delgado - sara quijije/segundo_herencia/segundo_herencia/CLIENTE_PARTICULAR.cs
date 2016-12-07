using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace segundo_herencia
{
    class CLIENTE_PARTICULAR:CLIENTE
    {
        int tarjetaNumr;

        public int TarjetaNumr
        {
            get { return tarjetaNumr; }
            set { tarjetaNumr = value; }
        }

        public void pago()
        { }
             
            
    }
}
