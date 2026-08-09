using ClinicaVeterinaria.models;
using ClinicaVeterinaria.Repositories;

namespace ClinicaVeterinaria.Services;

public class PacienteServices
{
   public void RegistrarPaciente(Paciente paciente)
   {
      if (string.IsNullOrWhiteSpace(paciente.Nombre))
         throw new ArgumentException("El nombre no puede estar vacio");
   }
      
}