using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFutbol.Modelos;

namespace PracticaFutbol.Services
{
    public interface IEquipoRepositorioBD
    {
        //vamos a crear un método que devuelva todos los equipos y los devuelva en una lista, en este caso 
        //utilizamos la clase IEnumerable, actúa como la clase list
        IEnumerable<Equipo> GetAllEquipos(string elementoABuscar);
        //Aquí vamos a crear un método para que nos devuelva un objeto de la clase Equipo cuando le pases un entero
        Equipo GetEquipoById(int id);
        //Una función que guarde los cambios del equipo
        void Update(Equipo equipoActualizado);
        //un método que recibe un objeto de la clase Equipo y lo insertará en la lista de equipos
        void Add(Equipo equipoNuevo);
        //un método que reciba un objeto de la clase Equipo y lo elimine de la lista
        Equipo Delete(int idBorrar);
        //Un método que devuelva una lista de objetos de la clase EquipoCuantos
        //IEnumerable<EquipoCuantos> EquiposPorCategoria(Categoria? categoria);
        //un método para el get para que busque
        IEnumerable<Equipo> FindEquipos(string elementoABuscar);

        //IEnumerable<Equipo> FindEquiposByCategoria(Categoria elementoABuscar);
    }
}
