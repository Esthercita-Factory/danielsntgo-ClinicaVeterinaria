using ClinicaVeterinaria.models;
using ClinicaVeterinaria.Repositories;

namespace ClinicaVeterinaria.Services;

public static class PacienteServices
{
   // public static void RegistrarPaciente(PacienteMascota pacienteMascota)
   // {
   //    if (string.IsNullOrWhiteSpace(pacienteMascota.Nombre))
   //       throw new ArgumentException("El nombre no puede estar vacio");
   //    if (string.IsNullOrWhiteSpace(pacienteMascota.Raza))
   //       throw new ArgumentException("La raza no puede estar vacio");
   //    if (pacienteMascota.Edad <= 0)
   //       throw new ArgumentException("La edad debe ser mayor a 0");
   //    if (pacienteMascota.Peso <= 0)
   //       throw new ArgumentException("El peso debe ser mayor a 0");
   //    PacienteMascotaRepositories.RegistrarPaciente(pacienteMascota);
   // }
   //
   // public static PacienteMascota? BuscarPaciente(string nombre)
   // {
   //    if (string.IsNullOrWhiteSpace(nombre))
   //       throw new ArgumentException("Debe ingresar un nombre para buscar");
   //    string nombreNormalizado = nombre.Trim().ToLower();
   //    return PacienteMascotaRepositories.buscarPacientePorNombre(nombreNormalizado);
   // }
   //
   // public static List<PacienteMascota> MostrarPacienteListos()
   // {
   //    return PacienteMascotaRepositories.ListarPacientes();
   // }
}