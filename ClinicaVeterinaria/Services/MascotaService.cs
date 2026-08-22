using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Services;

public class MascotaServices : IMascotaService
{
    private IMascotaRepository _mascotaRepository;

    public MascotaServices(IMascotaRepository mascotaRepository)
    {
        _mascotaRepository = mascotaRepository;
    }

    public void Registrar(Mascota mascota)
    {
        throw new NotImplementedException();
    }

    public List<Mascota> obtenerTodos()
    {
        throw new NotImplementedException();
    }

    public List<Mascota> obtenerPorNombre(string nombreMascota)
    {
        throw new NotImplementedException();
    }

    public List<Mascota> obtenerPorEspecie(string especie)
    {
        throw new NotImplementedException();
    }

    public List<Mascota> obtenerPorRaza(string raza)
    {
        throw new NotImplementedException();
    }

    public List<Cita> obtenetCitas(Mascota mascota)
    {
        throw new NotImplementedException();
    }

    public void Actualizar(Mascota mascota)
    {
        throw new NotImplementedException();
    }

    public void AsignarCita(Mascota mascota, object cita)
    {
        throw new NotImplementedException();
    }

    public void desasignarCita(Mascota mascota, object cita)
    {
        throw new NotImplementedException();
    }
}