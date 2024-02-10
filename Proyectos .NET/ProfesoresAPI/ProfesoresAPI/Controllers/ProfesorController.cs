using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ProfesoresAPI.Controllers
{
    public class ProfesorController : ApiController
    {
        public IEnumerable<Profesores> Get()//Obtener todos los alumnos
        {
            using (ColegioEntities colegio = new ColegioEntities())
            {
                return colegio.Profesores.ToList();
            }
        }
        public Profesores Get(int id)//Obtener un alumno por id
        {
            using (ColegioEntities colegio = new ColegioEntities())
            {
                return colegio.Profesores.Find(id);
            }
        }
    }
}