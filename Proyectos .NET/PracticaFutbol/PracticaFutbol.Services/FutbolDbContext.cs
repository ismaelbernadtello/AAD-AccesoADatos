using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaFutbol.Modelos;

namespace PracticaFutbol.Services
{
    public class FutbolDbContext : DbContext
    {
        public FutbolDbContext(DbContextOptions<FutbolDbContext> options) : base(options)
        {
            //no tenemos que hacer nada más, se instancia el objeto
        }

        //En este caso la tabla sería alumnos que son un conjunto de objetos de la clase Alumno

        //Equipo es la tabla de la base de datos y Equipos es la 'lista' que se genera
        public DbSet<Equipo> Equipo { get; set; }


        //DbSet es un objeto equivalente a un ienumerable
        //y se usa para tratar tablas como listas y a sus elementos como items
    }
}