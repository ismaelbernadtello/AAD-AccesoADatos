using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PracticaFutbol.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Services
{
    public class EquipoRepositorioBD : IEquipoRepositorioBD
    {
        private readonly FutbolDbContext context;

        public EquipoRepositorioBD(FutbolDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Equipo> GetAllEquipos(string elementoABuscar)
        {
            if (string.IsNullOrEmpty(elementoABuscar))
            {//Si no se busca nada, devuelve todos los equipos de la base de datos
                return context.Equipo;
            }
            else
            {//Permite buscar por nombre de equipo
                return context.Equipo.Where(e => e.NombreEquipo.Contains(elementoABuscar));
            }

        }
        public void Add(Equipo equipoNuevo)
        {
            throw new NotImplementedException();
        }

        public Equipo Delete(int idBorrar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipo> FindEquipos(string elementoABuscar)
        {
            throw new NotImplementedException();
        }

        

        public IEnumerable<Equipo> GetAllEquipos()
        {
            throw new NotImplementedException();
        }

        public Equipo GetEquipoById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Equipo equipoActualizado)
        {
            throw new NotImplementedException();
        }
    }
}
