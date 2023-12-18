namespace Modelos
{
    public class Equipo
    {
        public int Id { get; set; }
        public string nomEquipo { get; set; }
        public string ciudad { get; set; }
        public string nomEstadio { get; set; }
        public string anoFundacion { get; set; }
        public Categoria categoria { get; set; }
        public string? imagen { get; set; }
        //El ? permitiria los nulos de la base de datos
    }
}