using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VallejoS_TallerLigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }

        [Range(0, 100)]
        public int PartidosJugados { get; set; }

        [Range(0, 100)]
        public int PartidosGanados { get; set; }

        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }

        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }

        public int Puntos
        {
            get
            {
                int puntos = PartidosGanados * 3 + PartidosEmpatados;
                return puntos;
            }
        }
    }
}
