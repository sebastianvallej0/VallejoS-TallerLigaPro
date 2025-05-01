using Microsoft.AspNetCore.Mvc;
using VallejoS_TallerLigaPro.Interfaces;
using VallejoS_TallerLigaPro.Models;

namespace VallejoS_TallerLigaPro.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IEquipoRepository _equipoRepo;

        public EquipoController(IEquipoRepository equipoRepo)
        {
            _equipoRepo = equipoRepo;
        }

        public IActionResult Index()
        {
            var equipos = _equipoRepo.DevuelveListadoEquipos();
            return View(equipos); // esto carga la vista Index.cshtml en /Views/Equipo/
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _equipoRepo.CrearEquipo(equipo);
                return RedirectToAction("Index");
            }
            return View(equipo);
        }

        public IActionResult Eliminar(int id)
        {
            _equipoRepo.EliminarEquipo(id);
            return RedirectToAction("Index");
        }
    }
}
