using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC2024.Controllers
{
    public class marcaController : Controller
    {
        //Aqui se crean los metodos que se van a llamar desde las vistas

        //Los metodos tendran el mismo nombre que las vistas

        // GET: marcaController
        public ActionResult Index() //metodo que devuelve una vista
        {
            return View(); //devuelve la vista
        }

        // GET: marcaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //El método create esta declarado 2 veces, a la página del create se puede acceder a su método de dos maneras. A través del onGet o del onPost
        //Si se reciben parametros se accede al onPost, si no se reciben parametros se accede al onGet
        //Es decir, si se recibe un formulario se accede al onPost, si no se recibe un formulario se accede al onGet

        // GET: marcaController/Create
        public ActionResult Create() 
        {

            return View();
        }

        // POST: marcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: marcaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: marcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: marcaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: marcaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
