using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteMascotaRepositories
{
    public static List<Mascota> Pacientes { get; set; }

    static PacienteMascotaRepositories()
    {
        Pacientes = new List<Mascota>()
        {
            new Mascota("rocky", 3, 28, "labrador",null),
            new Mascota("michi", 2, 4, "siames", null),
            new Mascota("toby", 5, 15, "beagle", null),
            new Mascota("luna", 1, 3, "persa", null),
            new Mascota("max", 7, 32, "pastor aleman", null),
            new Mascota("nina", 4, 6, "poodle", null),
            new Mascota("simon", 6, 5, "criollo", null),
            new Mascota("coco", 2, 2, "chihuahua", null),
            new Mascota("bella", 3, 22, "golden retriever", null),
            new Mascota("oreo", 1, 4, "mestizo", null)

        };
    }
    
    
    public static void RegistrarPaciente(Mascota registrado)
    {
        Pacientes.Add(registrado);
    }
    
    public static List<Mascota> ListarPacientes()
    {
        return Pacientes;
    }
    
    public static Mascota? buscarPacientePorNombre(string nombre)
    {
      return Pacientes.FirstOrDefault(c => c.Nombre.Equals(nombre,StringComparison.OrdinalIgnoreCase));
    }


    
}