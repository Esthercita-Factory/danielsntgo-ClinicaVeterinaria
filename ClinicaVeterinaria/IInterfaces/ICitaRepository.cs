using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface ICitaRepository : ICrudOperations<Cita>
{
    DateTime ObtenerPorFecha(DateTime fecha);
    EstadoCita ObtenerEstadoCita(EstadoCita estado);
    TipoServicio ObtenerTipoServicio(TipoServicio tipoServicio);
}
