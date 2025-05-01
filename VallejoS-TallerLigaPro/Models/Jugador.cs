using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using VallejoS_TallerLigaPro.Models;

namespace VallejoS_LigaPro.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del jugador")]
        public string Nombre { get; set; }

        [Range(1, 99)]
        [DisplayName("Número de camiseta")]
        public int NumeroCamiseta { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Goles")]
        public int Goles { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Asistencias")]
        public int Asistencias { get; set; }

        [Range(0, double.MaxValue)]
        [DisplayName("Sueldo")]
        public double Sueldo { get; set; }

        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}