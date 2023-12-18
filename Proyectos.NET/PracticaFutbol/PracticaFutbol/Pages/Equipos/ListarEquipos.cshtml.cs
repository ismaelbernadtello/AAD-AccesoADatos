using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaFutbol.Modelos;
using PracticaFutbol.Services;


namespace PracticaFutbol.Pages.Equipos
{
    public class ListarEquiposModel : PageModel
    {   
        //declaramos un atributo de clase de la clase IEquipoRepositorioBD para poder llamar al m�todo GetAllEquipos
        private readonly IEquipoRepositorioBD equipoRepositorioBD;

        //para que salga IEquipoRepositorioBD a�ado la dependencia del .Service
        // y uso este objeto para llamar al m�todo GetAllEquipos()
        public IEnumerable<Equipo> EquiposLista;
        //cuando llamemos al GetAllEquipos nos devolver� una lista de objetos de la clase Equipo, por lo que creamos
        //un objeto de esa clase para poder llamarlo.
        public string ElementoABuscar { get; set; }

        public ListarEquiposModel(IEquipoRepositorioBD equipoRepositorioBD)
        {
            this.equipoRepositorioBD = equipoRepositorioBD;
            /*esto es inyecci�n de dependencias:
            * que sin llamar explicitamente a los m�todos constructores
            * se creen */
        }

        public void OnGet(string ElementoABuscar = "")
        {
            EquiposLista = equipoRepositorioBD.GetAllEquipos(ElementoABuscar);
        }
    }
}
