namespace SalonTurnos.Api.Models
{
    public class Turno
    {
        public enum EstadoTurno
        {
            Disponible,
            Reservado,
            Cancelado
        }

        public int Id { get; set; }
        public int SalonId { get; set; }
        public DateTime FechaHora { get; set; }
        public EstadoTurno Estado { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteTelefono { get; set; }
    }
}
