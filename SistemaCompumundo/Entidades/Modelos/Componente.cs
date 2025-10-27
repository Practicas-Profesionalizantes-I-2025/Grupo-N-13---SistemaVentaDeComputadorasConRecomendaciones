using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Componente : Producto 
    {

        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }


        public Componente(string Tipo, string marca, string Modelo, float Precio, int Cantidad) : base(Tipo, Precio, Cantidad)
        {
            this.Tipo = Tipo;
            this.Marca = marca;
            this.Modelo = Modelo;
            this.Precio = Precio;
            this.Cantidad = Cantidad;

        }


    }
}
