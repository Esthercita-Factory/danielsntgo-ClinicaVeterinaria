using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface ITutorRepository : ICrudOperations<Tutor>
{
    List<Tutor> BuscarPorCC(string cc);
    List<Tutor> BuscarPorNombre(string nombre);
    List<Mascota> obtenerMascotas(string nombreMascota);
}