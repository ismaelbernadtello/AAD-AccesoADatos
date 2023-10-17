using Microsoft.AspNetCore.Mvc;
using RazorPages.Service;

namespace RazorPages1.Components
{
    public class AlumnoCursoViewComponent : ViewComponent
    {
        public IAlumnoRepositorio AlumnoRepositorio { get;}

        public AlumnoCursoViewComponent(IAlumnoRepositorio alumnoRepositorio) 
        {
            AlumnoRepositorio = alumnoRepositorio;
        }

        public IViewComponentResult invoke()
        {
            var resultado = AlumnoRepositorio.AlumnosPorCurso();
            return View(resultado);
        }
    }
}
