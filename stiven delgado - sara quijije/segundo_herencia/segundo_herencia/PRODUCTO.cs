using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace segundo_herencia
{
    class PRODUCTO:ENCARGO
    {
        double id;
        double coste;
        
       
        public double consulta_producto1()
        {
            return id + coste;
        }


        public void ingresar_producto(double id, double coste)
        {
            id = coste;
        }
    }
}
