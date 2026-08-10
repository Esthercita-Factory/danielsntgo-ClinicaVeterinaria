using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteRepositories
{
    public static List<PacienteMascota> Pacientes { get; set; }

    static PacienteRepositories()
    {
        Pacientes = new List<PacienteMascota>()
        {
            new PacienteMascota("rocky", 3, 28, "labrador", "vomito y diarrea"),
            new PacienteMascota("michi", 2, 4, "siames", "estornudos frecuentes"),
            new PacienteMascota("toby", 5, 15, "beagle", "cojera en pata trasera"),
            new PacienteMascota("luna", 1, 3, "persa", "falta de apetito"),
            new PacienteMascota("max", 7, 32, "pastor aleman", "letargo y fiebre"),
            new PacienteMascota("nina", 4, 6, "poodle", "picazon excesiva"),
            new PacienteMascota("simon", 6, 5, "criollo", "herida en pata delantera"),
            new PacienteMascota("coco", 2, 2, "chihuahua", "tos persistente"),
            new PacienteMascota("bella", 3, 22, "golden retriever", "revision de rutina"),
            new PacienteMascota("oreo", 1, 4, "mestizo", "vacunacion anual")
        };
    }
    public static void RegistrarPaciente(PacienteMascota pacienteMascotaRegistrado)
    {
        Pacientes.Add(pacienteMascotaRegistrado);
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