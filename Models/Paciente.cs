namespace ClinicaAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Diagnostico { get; set; } = string.Empty;

        // Nuevos campos Ejercicio 01
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
    }
}