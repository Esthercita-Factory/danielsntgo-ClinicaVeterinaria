using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteMascotaRepositories
{
    public static List<PacienteMascota> Pacientes { get; set; }

    static PacienteMascotaRepositories()
    {
        Pacientes = new List<PacienteMascota>()
        {
            new PacienteMascota("rocky", 3, 28, "labrador", null),
            new PacienteMascota("michi", 2, 4, "siames", null),
            new PacienteMascota("toby", 5, 15, "beagle", null),
            new PacienteMascota("luna", 1, 3, "persa", null),
            new PacienteMascota("max", 7, 32, "pastor aleman", null),
            new PacienteMascota("nina", 4, 6, "poodle", null),
            new PacienteMascota("simon", 6, 5, "criollo", null),
            new PacienteMascota("coco", 2, 2, "chihuahua", null),
            new PacienteMascota("bella", 3, 22, "golden retriever", null),
            new PacienteMascota("oreo", 1, 4, "mestizo", null)

        };
    }
    
    
    public static void RegistrarPaciente(PacienteMascota pacienteRegistrado)
    {
        Pacientes.Add(pacienteRegistrado);
    }
    
    public static List<PacienteMascota> ListarPacientes()
    {
        return Pacientes;
    }
    
    public static PacienteMascota? buscarPacientePorNombre(string nombre)
    {
      return Pacientes.FirstOrDefault(c => c.Nombre.Equals(nombre,StringComparison.OrdinalIgnoreCase));
    }


    
}