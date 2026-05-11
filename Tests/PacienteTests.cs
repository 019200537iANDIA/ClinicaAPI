using ClinicaAPI.Models;

namespace ClinicaAPI.Tests
{
    public class PacienteTests
    {
        [Fact]
        public void Paciente_Nombre_SeAsignaCorrectamente()
        {
            var paciente = new Paciente();
            paciente.Nombre = "Juan Perez";
            Assert.Equal("Juan Perez", paciente.Nombre);
        }

        [Fact]
        public void Paciente_Edad_EsMayorQueCero()
        {
            var paciente = new Paciente();
            paciente.Edad = 35;
            Assert.True(paciente.Edad > 0);
        }
    }
}