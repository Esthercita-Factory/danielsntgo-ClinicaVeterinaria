using System.Globalization;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClibbnicaVeterinaria.Services;

public class CitaServices : ICitaService
{
    private ICitaRepository _citaRepository;

    public CitaServices(ICitaRepository citaRepository)
    {
        _citaRepository = citaRepository;
    }

    public void Registrar(Cita cita)
    { 
        
        if (cita == null)
        {
            throw new ArgumentNullException(nameof(cita), "La cita no puede ser nula.");
        }

        
        if (cita.Mascota == null)
        {
            throw new ArgumentException("La cita debe tener una mascota asignada.");
        }
        
        if (string.IsNullOrWhiteSpace(cita.Motivo))
        {
            throw new ArgumentException("El motivo de la cita es obligatorio.");
        }

        
        if (cita.Fecha <= DateTime.Now)
        {
            throw new InvalidOperationException("No se puede programar una cita para una fecha u hora pasada.");
        }

        
        if (cita.Fecha.Hour < 8 || cita.Fecha.Hour >= 18)
        {
            throw new InvalidOperationException("La cita debe estar dentro del horario de atención (8:00 AM - 6:00 PM).");
        }
        
        var citasDelDia = _citaRepository.ObtenerPorFecha(cita.Fecha);
        if (citasDelDia != null)
        {
            foreach (var citaExistente in citasDelDia)
            {
                
                if (citaExistente.Fecha == cita.Fecha && 
                    citaExistente.Mascota.Id == cita.Mascota.Id && 
                    citaExistente.Estado == EstadoCita.Confirmada) 
                {
                    throw new InvalidOperationException("La mascota ya tiene una cita agendada para esa misma hora.");
                }
            }
        }
        _citaRepository.Registrar(cita);

    }

    public List<Cita> ObtenerTodos()
    {
        var citas = _citaRepository.obtenerTodos();
        return citas ?? new List<Cita>(); 
    }

    public List<Cita> ObtenerPorFecha(DateTime fecha)
    {
        return _citaRepository.ObtenerPorFecha(fecha)
            .Where(cita => cita.Fecha.Date == fecha.Date)
            .ToList();
    }

    public List<Cita> ObtenerPorEstadoCita(EstadoCita estadoCita)
    {
        return _citaRepository.ObtenerPorEstadoCita(estadoCita)
            .Where(cita => cita.Estado == estadoCita)
            .ToList();
    }

    public List<Cita> ObtenerPorServicio(TipoServicio servicio)
    {
        return _citaRepository.ObtenerPorServicio(servicio)
            .Where(cita => cita.Servicio == servicio)
            .ToList();

    }

    public void Actualizar(Cita cita)
    {
        if (cita == null)
        {
            throw new ArgumentNullException(nameof(cita), "Los datos de la cita modificada no pueden ser nulos.");
        }
        var citaExistente = _citaRepository.obtenerTodos()
            .Find(c => c.Fecha == cita.Fecha && 
                       c.Mascota.Id == cita.Mascota.Id);
        if (citaExistente == null)
        {
            throw new KeyNotFoundException($"No se puede actualizar. La cita con ID {cita.Id} no existe en el sistema.");
        }
        _citaRepository.Actualizar(cita);
    }

    public void Eliminar(Cita cita)
    {
        var citaParaEliminar = _citaRepository.obtenerTodos()
            .Find(c => c.Fecha == cita.Fecha &&
                       c.Mascota.Id == cita.Mascota.Id );
            
        if (citaParaEliminar == null)
        {
            throw new KeyNotFoundException($"No se encontró ninguna cita {cita.Id} para ser eliminada.");
        }
        _citaRepository.Eliminar(citaParaEliminar);
    }

    public void Asignar(Cita cita, object mascota)
    {
        throw new NotImplementedException();
    }

    public void Designar(Cita cita, object mascota)
    {
        throw new NotImplementedException();
    }
}
