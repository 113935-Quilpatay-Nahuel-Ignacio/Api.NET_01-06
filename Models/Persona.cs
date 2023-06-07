using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3Api.NET.Models
{
    /*public class Persona
    {

    }*/

    [Table("personas")]
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
