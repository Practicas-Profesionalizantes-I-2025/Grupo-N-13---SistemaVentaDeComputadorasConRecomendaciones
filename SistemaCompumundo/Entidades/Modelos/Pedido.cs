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

        public string Remitente { get; set; }

        public DateTime FechaPedido { get; set; }


        public float TotalPedido { get; set; }


        //Referencias de Cardinalidades Cliente
        public int Id_Cliente { get; set; } // Fk de la clase correspondiente

        public Cliente cliente { get; set; } // Referencia de navegacion hacia el principal

        // Referencia Cardinalidades Administrador
        public int Id_Administrador { get; set; }

        public Administrador administrador { get; set; }



        //Referencia cardinalidades 1-N 

        public virtual ICollection<Componente> Componentes { get; set; } = new List<Componente>();

        //Referencia Cardinalidades 1-N

        public virtual ICollection<PcArmada> PcArmada { get; set; } = new List<PcArmada>();

        //Referencia Cardinalidades 1-1 

        public Ventas Ventas { get; set; }



        public Pedido(string Remitente,List<string> ProductosPedidos, DateTime FechaPedido,float TotalPedido)
        {

            this.Remitente = Remitente;
            this.ProductosPedidos = new List<string>();
            this.FechaPedido = FechaPedido;
            this.TotalPedido = TotalPedido;


        }


    }
}
