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
        // 1. Validar que el objeto no sea nulo
        if (cita == null)
        {
            throw new ArgumentNullException(nameof(cita), "La cita no puede ser nula.");
        }

        // 2. Validar que la mascota esté asignada
        if (cita.Mascota == null)
        {
            throw new ArgumentException("La cita debe tener una mascota asignada.");
        }

        // 3. Validar campos obligatorios de texto
        if (string.IsNullOrWhiteSpace(cita.Motivo))
        {
            throw new ArgumentException("El motivo de la cita es obligatorio.");
        }

        // 4. Validar reglas de negocio temporales (Fecha futura)
        if (cita.Fecha <= DateTime.Now)
        {
            throw new InvalidOperationException("No se puede programar una cita para una fecha u hora pasada.");
        }

        // 5. Validar horario de atención de la clínica (Ej: 8:00 AM a 6:00 PM)
        if (cita.Fecha.Hour < 8 || cita.Fecha.Hour >= 18)
        {
            throw new InvalidOperationException("La cita debe estar dentro del horario de atención (8:00 AM - 6:00 PM).");
        }

        // 6. Validar colisión de agenda filtrando en base a la lista devuelta por el repositorio
        // Tu repositorio devuelve todas las citas en 'ObtenerPorFecha(fecha)', así que filtramos en memoria
        var citasDelDia = _citaRepository.ObtenerPorFecha(cita.Fecha);
        if (citasDelDia != null)
        {
            foreach (var citaExistente in citasDelDia)
            {
                // Comparamos minutos exactos y que la mascota sea la misma con una cita activa
                if (citaExistente.Fecha == cita.Fecha && 
                    citaExistente.Mascota.Id == cita.Mascota.Id && 
                    citaExistente.Estado == EstadoCita.Confirmada) // Ajusta si tu Enum se llama diferente
                {
                    throw new InvalidOperationException("La mascota ya tiene una cita agendada para esa misma hora.");
                }
            }
        }
        _citaRepository.Registrar(cita);

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