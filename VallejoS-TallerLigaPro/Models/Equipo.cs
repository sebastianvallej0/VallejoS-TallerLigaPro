using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VallejoS_TallerLigaPro.Models
{
    
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }

        [Range(0, 100, ErrorMessage = "Los partidos jugados deben estar entre 0 y 100.")]
        [DisplayName("Partidos jugados")]
        public int PartidosJugados { get; set; }

        [Range(0, 100, ErrorMessage = "Los partidos ganados deben estar entre 0 y 100.")]
        [DisplayName("Partidos ganados")]
        public int PartidosGanados { get; set; }

        [Range(0, 100, ErrorMessage = "Los partidos empatados deben estar entre 0 y 100.")]
        [DisplayName("Partidos empatados")]
        public int PartidosEmpatados { get; set; }

        [Range(0, 100, ErrorMessage = "Los partidos perdidos deben estar entre 0 y 100.")]
        [DisplayName("Partidos perdidos")]
        public int PartidosPerdidos { get; set; }

        
        [DisplayName("Puntos totales")]
        public int Puntos => PartidosGanados * 3 + PartidosEmpatados;

        
        public bool ValidarPartidos() => PartidosJugados == (PartidosGanados + PartidosEmpatados + PartidosPerdidos);
    }
}
