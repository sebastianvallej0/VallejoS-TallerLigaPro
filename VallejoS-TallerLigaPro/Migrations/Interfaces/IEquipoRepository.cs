using VallejoS_TallerLigaPro.Models;

namespace VallejoS_TallerLigaPro.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int id);
        bool CrearEquipo(Equipo equipo);
        bool EditarEquipo(Equipo equipo);
        bool EliminarEquipo(int id);
    }
}
