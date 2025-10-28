using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Cuenta
    {

        public int Id { get; set; } 

        public string Facturacion { get; set; }

        public string Localidad { get; set; }


        public Cuenta(string Facturacion, string Localidad)
        {

            this.Facturacion = Facturacion;
            this.Localidad = Localidad;

        }

    }
}
