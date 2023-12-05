using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIsmaelBernad.Modelos;


namespace ExamenIsmaelBernad.Services
{
    public class ProvinciaDbContext : DbContext
    {
        public ProvinciaDbContext(DbContextOptions<ProvinciaDbContext> options) : base(options)
        {
            //no tenemos que hacer nada más, se instancia el objeto
        }

        //En este caso la tabla sería provincias que son un conjunto de objetos de la clase Provincia
        public DbSet<Provincia> Provincias { get; set; }
        //DbSet es un objeto equivalente a un ienumerable
        //y se usa para tratar tablas como listas y a sus elementos como items

    }
}