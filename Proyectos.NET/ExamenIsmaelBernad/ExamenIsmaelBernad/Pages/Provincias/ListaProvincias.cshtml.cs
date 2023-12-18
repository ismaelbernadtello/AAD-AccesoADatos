using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamenIsmaelBernad.Services;
using ExamenIsmaelBernad.Modelos;
using System.Runtime.CompilerServices;


namespace ExamenIsmaelBernad.Pages.Provincias
{
    public class ListaProvinciasModel : PageModel
    {
        //declaramos un atributo de clase de la clase IProvinciaRepositorio para poder llamar al método GetAllProvincias
        private readonly IProvinciaRepositorio provinciaRepositorio;
        //para que salga IProvinciaRepositorio añado la dependencia del .Service
        // y uso este objeto para llamar al método GetAllProvincias()
        
        public IEnumerable<Provincia> Provincias;
        //cuando llamemos al GetAllProvincias nos devolverá una lista de objetos de la clase Provincia, por lo que creamos
        //un objeto de esa clase para poder llamarlo.


        public void OnGet()
        {
            Provincias = provinciaRepositorio.GetAllProvincias();
        }


        public ListaProvinciasModel(IProvinciaRepositorio provinciaRepositorio)
        {
            this.provinciaRepositorio = provinciaRepositorio;
            /*esto es inyección de dependencias:
            * que sin llamar explicitamente a los métodos constructores
            * se creen */
        }
 
    }
}
