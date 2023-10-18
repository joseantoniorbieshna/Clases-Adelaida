using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAdelaida.Models
{
    internal class Cerveza : Bebida
    {
        public Cerveza() : base("Mahou", 200)
        {

        }
        public Cerveza(int cantidad, string nombre = "San Miguel")
            : base(nombre, cantidad)
        {

        }



    }
}
