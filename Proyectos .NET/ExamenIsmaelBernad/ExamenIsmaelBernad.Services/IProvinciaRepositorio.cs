using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIsmaelBernad.Modelos;

namespace ExamenIsmaelBernad.Services
{
    public interface IProvinciaRepositorio
    {
        //Método para listar las provincias
        IEnumerable<Provincia> GetAllProvincias();

        IEnumerable<ComunidadCuantos> ComunidadCuantosProvincia(Comunidad? comunidad);

        IEnumerable<Provincia> GetAllProvinciasPorComunidad(Comunidad? comunidad);
    }
}