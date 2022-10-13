using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public byte Imagen { get; set; }
        public int PeliculaId { get; set; }
        [ForeignKey("PeliculaId")]
        public virtual ICollection<Pelicula> Pelicula { get; set; }
    }
}
