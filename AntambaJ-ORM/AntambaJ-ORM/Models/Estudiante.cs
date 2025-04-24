using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AntambaJ_ORM.Models
{
    public class Estudiante
    {
        [Key]
        public int BannerID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneBeca { get; set; } 
        public int CarreraId { get; set; }

        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; } // Relación con la entidad Carrera
    }
}
