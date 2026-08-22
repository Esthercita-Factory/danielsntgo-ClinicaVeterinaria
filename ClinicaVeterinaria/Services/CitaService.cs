using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Services;

public class CitaServices : ICitaService
{
    private ICitaRepository _citaRepository;

    public CitaServices(ICitaRepository citaRepository)
    {
        _citaRepository = citaRepository;
    }

    public void Registrar(Cita cita)
    { 
        throw new NotImplementedException();
    }

    public List<Cita> ObtenerTodos()
    {
        throw new NotImplementedException();
    }

    public List<Cita> ObtenerPorFecha(DateTime fecha)
    {
        throw new NotImplementedException();
    }

    public List<Cita> ObtenerPorEstadoCita(EstadoCita estadoCita)
    {
        throw new NotImplementedException();
    }

    public List<Cita> ObtenerPorServicio(TipoServicio servicio)
    {
        throw new NotImplementedException();
    }

    public void Actualizar(Cita cita)
    {
        throw new NotImplementedException();
    }

    public void Eliminar(Cita cita)
    {
        throw new NotImplementedException();
    }
}