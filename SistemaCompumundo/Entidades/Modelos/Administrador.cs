using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Administrador
    {

        public int Id { get; set; }

        public string CodigoAdmin {  get; set; }

        public string ContraseniaAdmin { get; set; }


        public Administrador(string CodigoAdmin, string ContraseniaAdmin)
        {
            this.CodigoAdmin = CodigoAdmin;
            this.ContraseniaAdmin = ContraseniaAdmin;

        }

    }
}
