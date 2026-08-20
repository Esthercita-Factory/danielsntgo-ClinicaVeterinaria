using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class CitaRepositories : ICitaRepository
{
    private readonly List<Cita> _citas;
    
    public CitaRepositories(Almacen almacen)
    {
        _citas = almacen.Citas;
    }

    public void Registrar(Cita cita) =>  _citas.Add(cita);

    public List<Cita> Buscar() => _citas;
    public DateTime ObtenerPorFecha(DateTime fecha)
    {
        throw new NotImplementedException();
    }

    public EstadoCita ObtenerEstadoCita(EstadoCita estado)
    {
        throw new NotImplementedException();
    }

    public TipoServicio ObtenerTipoServicio(TipoServicio tipoServicio)
    {
        throw new NotImplementedException();
    }

    public void Actualizar(Cita cita)
    {
        cita.Motivo = cita.Motivo;
        cita.Fecha = cita.Fecha;
        cita.Servicio = cita.Servicio;
        cita.Estado =  cita.Estado;
    }

    public void Eliminar(Cita cita) => _citas.Remove(cita);

    public void Asignar(Cita cita, object mascota) => cita.Mascota = (Mascota)mascota;

    public void desasignar(Cita cita, object mascota) =>cita.Mascota = null;
   
}