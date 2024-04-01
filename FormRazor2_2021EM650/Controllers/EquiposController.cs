using FormRazor2_2021EM650.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormRazor2_2021EM650.Controllers
{
    public class EquiposController : Controller
    {
        private readonly EquiposContext _equiposContext;

        public EquiposController(EquiposContext equiposContext) 
        { 
            _equiposContext = equiposContext;
        }

        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposContext.Marcas 
                                 select m).ToList();
            ViewData["listaDeMarcas"] = new SelectList(listaDeMarcas, "IdMarcas", "NombreMarca");

            var listaDeTipos = (from t in _equiposContext.TipoEquipos
                                 select t).ToList();
            ViewData["listaDeTipos"] = new SelectList(listaDeTipos, "IdTipoEquipo", "Descripcion");

            var listaDeEstados = (from e in _equiposContext.EstadosEquipos
                                select e).ToList();
            ViewData["listaDeEstados"] = new SelectList(listaDeEstados, "IdEstadosEquipo", "Descripcion");

            var listadoEquipos = (from e in _equiposContext.Equipos
                                  join m in _equiposContext.Marcas on e.MarcaId equals m.IdMarcas
                                  select new { 
                                      nombre = e.Nombre,
                                      descripcion = e.Descripcion,
                                      marca_id = e.MarcaId,
                                      marca_nombre = m.NombreMarca
                                  }).ToList();
            ViewData["listadoEquipos"] = listadoEquipos;

            return View();
        }
        public IActionResult CrearEquipos(Equipo nuevoEquipo)
        {
            _equiposContext.Add(nuevoEquipo);
            _equiposContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
