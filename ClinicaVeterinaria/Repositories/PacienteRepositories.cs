using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteRepositories
{
    public static List<Paciente> Pacientes { get; set; }

    static PacienteRepositories()
    {
        Pacientes = new List<Paciente>()
        {
                    new Paciente("Rocky", 3, 28, "Labrador", "Vómito y diarrea"),
                    new Paciente("Michi", 2, 4, "Siames", "Estornudos frecuentes"),
                    new Paciente("Toby", 5, 15, "Beagle", "Cojera en pata trasera"),
                    new Paciente("Luna", 1, 3, "Persa", "Falta de apetito"),
                    new Paciente("Max", 7, 32, "Pastor Aleman", "Letargo y fiebre"),
                    new Paciente("Nina", 4, 6, "Poodle", "Picazon excesiva"),
                    new Paciente("Simon", 6, 5, "Criollo", "Herida en pata delantera"),
                    new Paciente("Coco", 2, 2, "Chihuahua", "Tos persistente"),
                    new Paciente("Bella", 3, 22, "Golden Retriever", "Revision de rutina"),
                    new Paciente("Oreo", 1, 4, "Mestizo", "Vacunacion anual") 
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

    public static void buscarPacientePorNombre( List<Paciente> lista, string nombre)
    {
        Pacientes.FirstOrDefault(c => c.Nombre == nombre);
    }
    
}