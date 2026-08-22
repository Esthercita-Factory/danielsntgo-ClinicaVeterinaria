using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Services;

public class TutorService : ITutorService
{
    private ITutorRepository _tutorRepository;

    public TutorService(ITutorRepository tutorRepository)
    {
        _tutorRepository = tutorRepository;
    }

    public void Registrar(Tutor tutor)
    {
        throw new NotImplementedException();
    }

    public List<Tutor> obtenerTodos()
    {
        throw new NotImplementedException();
    }

    public List<Tutor> BuscarPorCC(string cc)
    {
        throw new NotImplementedException();
    }

    public List<Tutor> BuscarPorNombre(string nombre)
    {
        throw new NotImplementedException();
    }

    public List<Mascota> obtenerMascotas(Tutor tutor)
    {
        throw new NotImplementedException();
    }

    public void Actualizar(Tutor tutor)
    {
        throw new NotImplementedException();
    }

    public void Eliminar(Tutor tutor)
    {
        throw new NotImplementedException();
    }

    public void Asignar(Tutor tutor, object mascota)
    {
        throw new NotImplementedException();
    }

    public void desasignar(Tutor tutor, object mascota)
    {
        throw new NotImplementedException();
    }
}