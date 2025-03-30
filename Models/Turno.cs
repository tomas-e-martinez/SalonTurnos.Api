namespace SalonTurnos.Api.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Disponible { get; set; }
        public string? ClienteNombre { get; set; }
        public string? ClienteEmail { get; set; }
        public string? ClienteTelefono { get; set; }
    }
}
