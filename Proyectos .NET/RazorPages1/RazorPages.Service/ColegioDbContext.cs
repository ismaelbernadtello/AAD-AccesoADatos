using System;
using Microsoft.EntityFrameworkCore;
using RazorPages.Modelos;

namespace RazorPages.Service
{
	internal class ColegioDbContext : DbContext
	{
        /*Esto es la base de datos y se hace inyección de dependencias de la clase D*/
        public ColegioDbContext(DbContextOptions<ColegioDbContext> options) : base (options)
        {
            
        }
        
        /*Esto es una tabla*/
        public DbSet<Alumno> Alumnos { get; set; }
        
    }
}

