using VallejoS_TallerLigaPro.Models;

namespace VallejoS_TallerLigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipo;
        public EquipoRepository()
        {
            Equipo = DevuelveListadoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 9,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            };
            Equipo emelec = new Equipo
            {
                Id = 3,
                Nombre = "Emelec",
                PartidosJugados = 8,
                PartidosGanados = 5,
                PartidosEmpatados = 6,
                PartidosPerdidos = 3
            };
            equipos.Add(emelec);
            equipos.Add(ldu);
            equipos.Add(barcelona);

            return equipos;
        }

        public Equipo DevuelveEquipoPorID(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = Equipo.First(item => item.Id == Id);

            return equipo;
        }

        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
            //logica de actualizacion
            return true;
        }

        public bool CrearEquipo(Equipo nuevoEquipo)
        {
            var listaEquipos = Equipo.ToList();
            int nuevoId = listaEquipos.Count > 0 ? listaEquipos.Max(e => e.Id) + 1 : 1;
            nuevoEquipo.Id = nuevoId;

            listaEquipos.Add(nuevoEquipo);
            Equipo = listaEquipos;

            return true;
        }

        public bool EliminarEquipo(int id)
        {
            var listaEquipos = Equipo.ToList();
            var equipoAEliminar = listaEquipos.FirstOrDefault(e => e.Id == id);

            if (equipoAEliminar != null)
            {
                listaEquipos.Remove(equipoAEliminar);
                Equipo = listaEquipos;
                return true;
            }

            return false;
        }
    }
}
