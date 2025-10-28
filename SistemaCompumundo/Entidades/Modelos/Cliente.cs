namespace Entidades.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contrasenia { get; set; }



        public Cliente(string Nombre,string Correo, string Contrasenia)
        {

            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Contrasenia = Contrasenia;

        }


    }
}
