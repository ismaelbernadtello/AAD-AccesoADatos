using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages1.Pages.Alumnos
{
    public class BuscarModel : PageModel
    {
        public void OnGet(string elementoABuscar = "") /*Si el par�metro recibe algo se usa ese valor sino se usa por defecto lo que pongamos entre comillas*/
        {
        }
    }
}
