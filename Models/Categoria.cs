using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3Api.NET.Models
{
    /*public class Categoria
    {

    }*/

    [Table("categorias")]
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
