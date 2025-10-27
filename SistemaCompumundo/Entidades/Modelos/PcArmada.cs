using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class PcArmada : Producto 
    {

        public int Id { get; set; }

        public Componente Componentes { get; set; }

        public float PrecioTotal { get; set; }


        public PcArmada(string Tipo, Componente Componentes, float PrecioTotal) : base(Tipo)
        {



        }





    }
}
