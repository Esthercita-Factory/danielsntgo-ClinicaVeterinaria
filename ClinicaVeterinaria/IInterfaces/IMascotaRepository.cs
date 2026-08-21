using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface IMascotaRepository : ICrudOperations<Mascota>
{
    List<Mascota> obtenerPorNombre(string nombreMascota);
    List<Mascota> obtenerPorEspecie(string especie);
    List<Mascota> obtenerPorRaza(string raza);
    List<Cita> obtenetCitas(Mascota mascota);
    void AsignarCita(Mascota mascota, object cita);
    void desasignarCita(Mascota mascota, object cita);
     
}