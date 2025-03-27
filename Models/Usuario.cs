namespace SalonTurnos.Api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreSalon { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Domicilio { get; set; }
    }
}
