using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Pedido
    {

        public int Id { get; set; }

        public Cliente Remitente { get; set; }

        public List<string> ProductosPedidos { get; set; }

        public DateTime FechaPedido { get; set; }


        public string EstadoPedido { get; set; }

        public float TotalPedido { get; set; }


        public Pedido(Cliente Remitente,List<string> ProductosPedidos, DateTime FechaPedido, string EstadoPedido,float TotalPedido)
        {

            this.Remitente = Remitente;
            this.ProductosPedidos = new List<string>();
            this.FechaPedido = FechaPedido;
            this.EstadoPedido = EstadoPedido;
            this.TotalPedido = TotalPedido;


        }


    }
}
