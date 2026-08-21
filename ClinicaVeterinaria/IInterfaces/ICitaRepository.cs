using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface ICitaRepository : ICrudOperations<Cita>
{
    List<Cita> ObtenerPorFecha(DateTime fecha);
    List<Cita> ObtenerPorEstadoCita(EstadoCita estado);
    List<Cita> ObtenerPorServicio(TipoServicio servicio);
}
