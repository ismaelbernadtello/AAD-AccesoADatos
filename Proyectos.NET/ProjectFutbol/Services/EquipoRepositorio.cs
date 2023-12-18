using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Services
{
    public class EquipoRepositorio : IEquipoRepositorio
	{
        private readonly FutbolDbContext context;

        public EquipoRepositorio(FutbolDbContext context)
        { 
            this.context = context;
		
		}
        public IEnumerable<Equipo> GetAllEquipos()
        {
            return context.Equipo;
        }
        public Equipo GetEquipoById(int id)
        {
            SqlParameter parameter = new SqlParameter("@Id", id);

            return context.Equipo.Find(id);
        }
        public void Add(Equipo equipoNuevo)
        {
            var cosa = context.Equipo.Max(a => a.Id);
            context.Equipo.Add(equipoNuevo);
            context.SaveChanges();

            return;
        }

        public Equipo Delete(int idBorrar)
        {
            Equipo equipoBorrar = context.Equipo.Find(idBorrar);
            if (equipoBorrar != null)
            {
                context.Equipo.Remove(equipoBorrar);
                context.SaveChanges();
            }
            return equipoBorrar;
        }

        public void Update(Equipo equipoActualizado)
        {
            var equipo = context.Equipo.Attach(equipoActualizado);
            equipo.State = Microsoft.EntityFrameworkCore.EntityState.Modified;//en lugar de guardar cambios
            context.SaveChanges();
        }

        public IEnumerable<CategoriaCuantos> EquiposPorCategoria(Categoria? categoria)
        {
            IEnumerable<Equipo> consulta = context.Equipo;
            if (categoria.HasValue)
            {
                consulta = consulta.Where(e => e.categoria == categoria).ToList();
            }

            return consulta.GroupBy(e => e.categoria)
                .Select(g => new CategoriaCuantos()//g es por el aGrupamiento
                {
                    Categoria = g.Key,
                    NumEquipos = g.Count()
                }).ToList();//el resultado lo convertimos en lista

        }

       
    }
}

