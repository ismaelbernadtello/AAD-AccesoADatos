using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Modelos
{
    public class Equipo
    {

        public int id { get; set; }

        //Esto es para que el nombreEquipo sea obligatorio, y que tenga un mínimo de 3 caracteres
        [Required(ErrorMessage = "Obligatorio completar el nombre")]//Esto es para que el nombre sea obligatorio
        [MinLength(3, ErrorMessage = "El nombre deber tener un mínimo de 3 caracteres")]

        public string NombreEquipo { get; set; }
        
        public string ciudad { get; set; }

        public string nomEstadio { get; set; }

        public int anoFundacion { get; set; }

        public int categoria { get; set;}
       
    }
}
