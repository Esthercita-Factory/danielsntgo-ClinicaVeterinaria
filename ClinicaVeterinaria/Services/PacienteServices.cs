using ClinicaVeterinaria.models;
using ClinicaVeterinaria.Repositories;

namespace ClinicaVeterinaria.Services;

public static class PacienteServices
{
   public static void RegistrarPaciente(Paciente paciente)
   {
      if (string.IsNullOrWhiteSpace(paciente.Nombre))
         throw new ArgumentException("El nombre no puede estar vacio");
      if (string.IsNullOrWhiteSpace(paciente.Raza))
         throw new ArgumentException("La raza no puede estar vacio");
      if (paciente.Edad <= 0)
         throw new ArgumentException("La edad debe ser mayor a 0");
      if (paciente.Peso <= 0)
         throw new ArgumentException("El peso debe ser mayor a 0");
      PacienteRepositories.RegistrarPaciente(paciente);
   }

   public static Paciente? BuscarPaciente(string nombre)
   {
      if (string.IsNullOrWhiteSpace(nombre))
         throw new ArgumentException("Debe ingresar un nombre para buscar");
      string nombreNormalizado = nombre.Trim().ToLower();
      return PacienteRepositories.buscarPacientePorNombre(nombreNormalizado);
   }

   public static List<Paciente> MostrarPacienteListos()
   {
      return PacienteRepositories.ListarPacientes();
   }
}