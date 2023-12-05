using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIsmaelBernad.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ExamenIsmaelBernad.Services
{
    public class ProvinciaRepositorioBD : IProvinciaRepositorio
    {
        private readonly ProvinciaDbContext context;
        //Cada vez que se use context es el equivalente a llamar a la base de datos a través de la conexión
        public ProvinciaRepositorioBD(ProvinciaDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Provincia> GetAllProvincias()
        {
            //return context.Provincias; //este método sólo devuelve la lista
            return context.Provincias.FromSqlRaw<Provincia>("SELECT * FROM Provincias").ToList();
            //También se puede hacer con return context.Provincias
        }

        public IEnumerable<ProvinciaComunidad> GetProvinciasComunidad(Comunidad? comunidad)
        {
            IEnumerable<Provincia> consulta = context.Provincias;
            if (comunidad.HasValue)
            {
                consulta = consulta.Where(p => p.codComunidad == comunidad).ToList();
            }

            return consulta.GroupBy(p => p.codComunidad)
                .Select(g => new ProvinciaComunidad() 
                { 
                    Comunidad = g.Key.Value,
                    superficieTotal = g.Sum(p => p.superficie),
                    numHabitantesTotal = g.Sum(p => p.numHabitantes),
                    numProvinciasTotal = g.Count()
                }).ToList();
                }
        }

}
