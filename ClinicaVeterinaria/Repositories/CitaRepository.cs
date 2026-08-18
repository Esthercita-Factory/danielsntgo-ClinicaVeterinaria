using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class CitaRepositories : ICrudOperations<Cita>
{
    public static List<Cita> Citas { get; set; }
    
    public CitaRepositories(List<Mascota> mascotas)
    {
        Citas = new List<Cita>()
        {
            new Cita("control anual", new DateTime(2026, 8, 15, 9, 0, 0),TipoServicio.ConsultaGeneral,EstadoCita.Confirmada,mascotas[0]),
            new Cita("vacunacion", new DateTime(2026, 8, 16, 10, 30, 0),TipoServicio.Vacunacion,EstadoCita.Pendiente,mascotas[1]),
            new Cita("desparasitacion", new DateTime(2026, 8, 17, 11, 0, 0),TipoServicio.ConsultaGeneral,EstadoCita.Pendiente,mascotas[2]),
            new Cita("revision de peso", new DateTime(2026, 8, 18, 14, 0, 0),TipoServicio.ConsultaGeneral,EstadoCita.Confirmada,mascotas[3]),
            new Cita("consulta general", new DateTime(2026, 8, 19, 8, 30, 0),TipoServicio.ConsultaGeneral,EstadoCita.Cancelado,mascotas[4]),
            new Cita("limpieza dental", new DateTime(2026, 8, 20, 15, 0, 0),TipoServicio.ConsultaGeneral,EstadoCita.Pendiente,mascotas[5]),
            new Cita("control anual", new DateTime(2026, 8, 21, 9, 30, 0),TipoServicio.ConsultaGeneral,EstadoCita.Confirmada,mascotas[6]),
        };
    }

    public void Registrar(Cita cita) => Citas.Add(cita);

    public List<Cita> Buscar() => Citas;

    public void Actualizar(Cita entidad)
    {
        // modificar todos  los metodos acrualizar
        var existente = Citas.Find(c => c.Id == entidad.Id);
        if (existente != null)
        {
            existente.Motivo = entidad.Motivo;
            existente.Fecha = entidad.Fecha;
            existente.Servicio = entidad.Servicio;
            existente.Estado = entidad.Estado;
            existente.Mascota = entidad.Mascota;
        }
    }

    public void Eliminar(Cita cita) => Citas.Remove(cita);

    public void Asignar(Cita cita, object mascota)
    {
        cita.Mascota = (Mascota)mascota;
        Citas.Add(cita);
    }
}