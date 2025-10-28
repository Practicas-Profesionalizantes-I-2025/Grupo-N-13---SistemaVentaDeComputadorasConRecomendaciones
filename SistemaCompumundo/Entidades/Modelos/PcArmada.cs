using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class PcArmada
    {

        public int Id { get; set; }   

        public string Tipo { get; set; }

        public List<Componente> Componentes { get; set; }

        public int Cantidad { get; set; }

        public float PrecioTotal { get; set; }


        public PcArmada(string Tipo, Componente Componentes, int Cantidad, float PrecioTotal)
        {

            this.Tipo = Tipo;
            this.Componentes = new List<Componente>();
            this.Cantidad = Cantidad;
            this.PrecioTotal = PrecioTotal;



        }





    }
}
