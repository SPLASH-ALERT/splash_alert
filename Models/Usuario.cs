namespace splash_alert.Models
{
   
    public class Usuario
    {
        public int IdUsuario { get; set; } 
        public string Nombre { get; set; }

        public string apellido { get; set; }
         
        public  string usuario { get; set; }

        public string contrasena { get; set; }

        public string correo { get; set; }

        public DateTime fecha_de_nacimiento { get; set; }   

        public string estado { get; set; }

        public int id_rol { get; set; }

    }
}
