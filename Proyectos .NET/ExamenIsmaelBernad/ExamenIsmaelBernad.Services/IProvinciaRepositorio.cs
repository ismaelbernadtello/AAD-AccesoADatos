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

        IEnumerable<ProvinciaComunidad> GetProvinciasComunidad(Comunidad? comunidad);

    }
}