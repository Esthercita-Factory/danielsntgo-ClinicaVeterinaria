using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;
using System.Linq;

namespace ClinicaVeterinaria.Repositories;

public class CitaRepository : ICitaRepository
{
    private List<Cita> _citas;
    
    public CitaRepository(Almacen almacen)
    {
        _citas = almacen.Citas;
    }

    public void Registrar(Cita cita) => _citas.Add(cita);
    public List<Cita> obtenerTodos() =>  _citas;
    public List<Cita> ObtenerPorFecha(DateTime fecha) => _citas;
    public List<Cita> ObtenerPorEstadoCita(EstadoCita estado) => _citas;
    public List<Cita> ObtenerPorServicio(TipoServicio servicio) => _citas;
    public void Actualizar(Cita cita)
    {
            cita.Motivo = cita.Motivo;
            cita.Fecha = cita.Fecha;
            cita.Servicio = cita.Servicio;
            cita.Estado = cita.Estado;
            cita.Mascota = cita.Mascota;
    }
    public void Eliminar(Cita cita) => _citas.Remove(cita);
    public void Asignar(Cita cita, object mascota) => cita.Mascota = (Mascota)mascota;
    public void desasignar(Cita cita, object mascota) => cita.Mascota = null;
    
   
}