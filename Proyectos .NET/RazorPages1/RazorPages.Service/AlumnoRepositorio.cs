using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Service
{
    public class AlumnoRepositorio : IAlumnoRepositorio //los : sirven para el extends y el implements de Java
        //luego le damos a la ayuda y le damos a implementar interfaz
    {
        public List<Alumno> ListaAlumnos; //creamos el objeto ListaAlumos de la clase List, que será un atributo de la clase

        public AlumnoRepositorio() //ctor nos crea el método constructor
        {
            //vamos a cargar los datos en la lista
            //instanciamos la lista y la cargamos
            ListaAlumnos = new List<Alumno>()
            { //cargamos la lista
                new Alumno()
                {
                    Id=1,
                    Nombre="Alberto Saz",
                    Email="saz@zaragoza.salesianos.edu",
                    Foto="Alberto.jpg",
                    CursoId = Curso.H2
                },
                new Alumno()
                {
                    Id=2,
                    Nombre="Jesús Montero",
                    Email="montero@zaragoza.salesianos.edu",
                    Foto="Jesus.jpg",
                    CursoId = Curso.H2
                },
                new Alumno()
                {
                    Id=3,
                    Nombre="Ismael Bernad",
                    Email="bernad@zaragoza.salesianos.edu",
                    Foto="Ismael2.jpg",
                    CursoId = Curso.H1
                },
                new Alumno()
                {
                    Id=4,
                    Nombre="Ismael Abed",
                    Email="abed@zaragoza.salesianos.edu",
                    Foto="Isma1.jpg",
                    CursoId = Curso.H1
                }
            };
        }
        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return ListaAlumnos; //este método sólo devuelve la lista
            /*a un IEnumerable le está pasando un List y lo acepta porque
             prácticamente es lo mismo
             */
        }
        public Alumno GetAlumnoById(int id)
        {
            /*a es el operador lambda, es una especie de alias para manipular el 
             * objeto a través del cual has llamado a la función. 
             * en este caso ListaAlumnos
             * FirstOrDefault busca la primera ocurrencia
             * Esta forma de trabajar se llama modo predicado*/
            return ListaAlumnos.FirstOrDefault(a => a.Id == id);
        }

        //Metodo para editar los datos de un alumno
        public void Update(Alumno alumnoActualizado)
        {
            Alumno alumno = ListaAlumnos.FirstOrDefault(a => a.Id == alumnoActualizado.Id);
            alumno.Nombre = alumnoActualizado.Nombre;
            alumno.Email = alumnoActualizado.Email;
            alumno.CursoId = alumnoActualizado.CursoId;
            alumno.Foto = alumnoActualizado.Foto;
            
        }

        //Metodo para añadir un alumno nuevo
        public Alumno Add(Alumno alumnoNuevo)
        {
            //Para el ID no podemos dejar que el usuario eliga, tenemos que poner el último que exista + 1
            //Buscamos en la lista de alumnos el máximo id
            alumnoNuevo.Id = ListaAlumnos.Max(a => a.Id) + 1; //Volvemos a usar el operador lambda
            ListaAlumnos.Add(alumnoNuevo); //Añadimos el alumno a la lista


            return alumnoNuevo;
        }
    }
}
