using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3Api.NET.Models
{
    /*public class Usuario
    {
    }*/

    [Table("usuarios")]
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsu { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
