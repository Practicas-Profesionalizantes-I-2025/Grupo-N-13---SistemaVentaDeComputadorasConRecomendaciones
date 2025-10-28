using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Ventas
    {
        public int Id { get; set; }

        public List<Producto> ProductoVendido { get; set; }

        public Cliente ClienteComprador { get; set; }

        public DateTime FechaVenta { get; set; }

        public Ventas(int id, Producto productoVendido, Cliente clienteComprador, DateTime fechaVenta)
        {
            Id = id;
            ProductoVendido = new List<Producto>();
            ClienteComprador = clienteComprador;
            FechaVenta = fechaVenta;
        }
    }
}
