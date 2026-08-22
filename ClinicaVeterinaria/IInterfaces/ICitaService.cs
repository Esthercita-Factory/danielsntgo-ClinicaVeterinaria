using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface ICitaService 
{
    void Registrar(Cita cita);
    List<Cita> ObtenerTodos();
    List<Cita> ObtenerPorFecha(DateTime fecha);
    List<Cita> ObtenerPorEstadoCita(EstadoCita estadoCita);
    List<Cita> ObtenerPorServicio(TipoServicio servicio);
    void Actualizar(Cita cita);
    void Eliminar(Cita cita);
    void Asignar(Cita cita, object mascota);
    void Designar(Cita cita, object mascota);
}