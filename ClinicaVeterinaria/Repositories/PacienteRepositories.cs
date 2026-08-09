using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteRepositories
{
    public static List<Paciente> Pacientes { get; set; }

    static PacienteRepositories()
    {
        Pacientes = new List<Paciente>()
        {
            new Paciente("rocky", 3, 28, "labrador", "vomito y diarrea"),
            new Paciente("michi", 2, 4, "siames", "estornudos frecuentes"),
            new Paciente("toby", 5, 15, "beagle", "cojera en pata trasera"),
            new Paciente("luna", 1, 3, "persa", "falta de apetito"),
            new Paciente("max", 7, 32, "pastor aleman", "letargo y fiebre"),
            new Paciente("nina", 4, 6, "poodle", "picazon excesiva"),
            new Paciente("simon", 6, 5, "criollo", "herida en pata delantera"),
            new Paciente("coco", 2, 2, "chihuahua", "tos persistente"),
            new Paciente("bella", 3, 22, "golden retriever", "revision de rutina"),
            new Paciente("oreo", 1, 4, "mestizo", "vacunacion anual")
        };
    }
    public static void RegistrarPaciente(Paciente pacienteRegistrado)
    {
        Pacientes.Add(pacienteRegistrado);
    }

    public static List<Paciente> ListarPacientes()
    {
        return Pacientes;
    }

    public static Paciente? buscarPacientePorNombre(string nombre)
    {
      return Pacientes.FirstOrDefault(c => c.Nombre.Equals(nombre,StringComparison.OrdinalIgnoreCase));
    }
    
}