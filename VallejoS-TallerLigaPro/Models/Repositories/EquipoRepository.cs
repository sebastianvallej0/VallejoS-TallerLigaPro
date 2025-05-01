using VallejoS_TallerLigaPro.Models;
using System.Linq;
using System.Collections.Generic;

namespace VallejoS_TallerLigaPro.Repositories
{
    public class EquipoRepository
    {
        private List<Equipo> equipos;

        public EquipoRepository()
        {
            equipos = DevuelveListadoEquipos().ToList();
        }

        // Devuelve el listado de equipos
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return new List<Equipo>
            {
                new Equipo
                {
                    Id = 1,
                    Nombre = "Liga de Quito",
                    PartidosJugados = 10,
                    PartidosGanados = 7,
                    PartidosPerdidos = 0,
                    PartidosEmpatados = 0
                },
                new Equipo
                {
                    Id = 2,
                    Nombre = "Barcelona",
                    PartidosJugados = 10,
                    PartidosGanados = 9,
                    PartidosPerdidos = 0,
                    PartidosEmpatados = 0
                },
                new Equipo
                {
                    Id = 3,
                    Nombre = "Emelec",
                    PartidosJugados = 8,
                    PartidosGanados = 5,
                    PartidosEmpatados = 6,
                    PartidosPerdidos = 3
                }
            };
        }

        // Devuelve un equipo por su ID
        public Equipo DevuelveEquipoPorID(int id)
        {
            return equipos.FirstOrDefault(item => item.Id == id);
        }

        // Actualiza la información de un equipo
        public bool ActualizarEquipo(int id, Equipo equipoActualizado)
        {
            var equipoExistente = equipos.FirstOrDefault(e => e.Id == id);

            if (equipoExistente != null)
            {
                equipoExistente.Nombre = equipoActualizado.Nombre;
                equipoExistente.PartidosJugados = equipoActualizado.PartidosJugados;
                equipoExistente.PartidosGanados = equipoActualizado.PartidosGanados;
                equipoExistente.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
                equipoExistente.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                return true;
            }
            return false; // Si no se encuentra el equipo con el ID
        }

        // Crea un nuevo equipo y lo agrega a la lista
        public bool CrearEquipo(Equipo nuevoEquipo)
        {
            // Asignamos un nuevo ID automáticamente
            int nuevoId = equipos.Count > 0 ? equipos.Max(e => e.Id) + 1 : 1;
            nuevoEquipo.Id = nuevoId;

            equipos.Add(nuevoEquipo);
            return true;
        }

        // Elimina un equipo por su ID
        public bool EliminarEquipo(int id)
        {
            var equipoAEliminar = equipos.FirstOrDefault(e => e.Id == id);

            if (equipoAEliminar != null)
            {
                equipos.Remove(equipoAEliminar);
                return true;
            }

            return false; // Si no se encuentra el equipo con el ID
        }
    }
}
