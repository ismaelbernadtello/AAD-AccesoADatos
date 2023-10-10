using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos

{
    public class DeleteModel : PageModel
    {
        private readonly IAlumnoRepositorio alumnoRepositorio;
        public Alumno alumno { get; set; }

        public DeleteModel(IAlumnoRepositorio alumnoRepositorio) 
        {
            this.alumnoRepositorio = alumnoRepositorio;
        }
        public void OnGet(int id)
        {
            alumno = alumnoRepositorio.GetAlumnoById(id);
        }
        public void Confirmar(int id)
        {

        }
    }
}
