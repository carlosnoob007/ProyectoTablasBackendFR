using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FariñoRosasProyect.Models{


    public class Usuario{

        public int id { get; set; }

        [Required]
        [Column(TypeName ="varchar(10)")]
        public String nombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String clave { get; set; }

        public Boolean estado { get; set; }

        //////////////////////////////////////////////

        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}

