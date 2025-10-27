using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public float Precio { get; set; }

        public int Cantidad { get; set; }

        public Producto(string Tipo, float Precio, int Cantidad)
        {
            this.Tipo=Tipo;
            this.Precio=Precio;
            this.Cantidad = Cantidad;

        }
    }
}
