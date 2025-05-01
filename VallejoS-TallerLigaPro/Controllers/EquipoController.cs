using Microsoft.AspNetCore.Mvc;
using VallejoS_TallerLigaPro.Models;
using VallejoS_TallerLigaPro.Interfaces;

namespace VallejoS_TallerLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IEquipoRepository _repository;

        // Se usa inyección de dependencias para el repositorio
        public EquipoController(IEquipoRepository repository)
        {
            _repository = repository;
        }

        // Vista principal con el listado de equipos
        public IActionResult Index()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            var ordenados = equipos.OrderByDescending(e => e.PartidosGanados).ToList(); // orden descendente por ganados
            return View(ordenados);
        }

        // Mostrar formulario para crear equipo
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _repository.CrearEquipo(equipo);
                return RedirectToAction(nameof(Index));
            }
            return View(equipo);
        }

        // Mostrar formulario para editar un equipo existente
        public IActionResult Edit(int id)
        {
            var equipo = _repository.DevuelveInfoEquipo(id);
            if (equipo == null) return NotFound();
            return View(equipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Equipo equipo)
        {
            if (id != equipo.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _repository.EditarEquipo(equipo);
                return RedirectToAction(nameof(Index));
            }
            return View(equipo);
        }

        // Mostrar confirmación para eliminar un equipo
        public IActionResult Delete(int id)
        {
            var equipo = _repository.DevuelveInfoEquipo(id);
            if (equipo == null) return NotFound();
            return View(equipo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.EliminarEquipo(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
