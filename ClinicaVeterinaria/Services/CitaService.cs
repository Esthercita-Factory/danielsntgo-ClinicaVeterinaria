using ClinicaVeterinaria.Repositories;

namespace ClinicaVeterinaria.Services;

public class CitaServices : IRegistrable
{
    public void Registrar()
    {
        Console.WriteLine("Registrando cita veterinaria...");
        Console.WriteLine("Cita registrada exitosamente.");
    }
}