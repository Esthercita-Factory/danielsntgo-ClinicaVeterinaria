using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteRepositories
{
    public static List<Paciente> Pacientes { get; set; }

    static PacienteRepositories()
    {
        Pacientes = new List<Paciente>();
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
        
    }
}