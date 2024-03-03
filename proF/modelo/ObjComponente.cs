using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proF.modelo
{
    public class ObjComponente
    {
        public string nombre { get; set; }

        public double precio { get; set; }

        public int tipo { get; set; }

        public ObjComponente(string nombre, double precio, int tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;

        }


    }
}
