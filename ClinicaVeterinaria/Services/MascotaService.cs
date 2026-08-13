using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Services;

public class MascotaServices : IRegistrable
{
    public void Registrar()
    {
        Console.WriteLine("Registrando mascota...");
        Console.WriteLine("Mascota registrada exitosamente.");
    }
}