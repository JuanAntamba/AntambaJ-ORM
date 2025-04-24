using System.ComponentModel.DataAnnotations;

namespace AntambaJ_ORM.Models
{
    public class Facultad
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
