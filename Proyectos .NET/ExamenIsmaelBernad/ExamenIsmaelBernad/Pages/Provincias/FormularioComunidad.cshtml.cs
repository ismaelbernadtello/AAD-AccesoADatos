using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamenIsmaelBernad.Modelos;
using ExamenIsmaelBernad.Services;
using Microsoft.AspNetCore.Hosting;


namespace ExamenIsmaelBernad.Pages.Provincias
{
    public class FormularioComunidadModel : PageModel
    {
        private readonly IProvinciaRepositorio provinciaRepositorio;
       

        public IEnumerable<Comunidad> Comunidad;

        public IEnumerable<Provincia> Provincias;

        //No me ha dado tiempo a terminarlo

        public FormularioComunidadModel(IProvinciaRepositorio provinciaRepositorio)
        {
            this.provinciaRepositorio = provinciaRepositorio;
            /*esto es inyección de dependencias:
            * que sin llamar explicitamente a los métodos constructores
            * se creen */
        }



        public IActionResult OnGet(Comunidad? comunidad)
        {
            if (comunidad != null) //Si se ha seleccionado una comunidad, se muestran las provincias de esa comunidad
            {
            Provincias = provinciaRepositorio.GetAllProvinciasPorComunidad(comunidad);
            }
            return Page();
        }


    }
}
