using MVC2024.Controllers;

namespace MVC2024.Models
{
    public class VehiculoModelo
    {

        public int ID { get; set; }
        public string? Matricula { get; set; }

        public string Color { get; set; }

        public SerieModelo Serie { get; set; }

    }
}
