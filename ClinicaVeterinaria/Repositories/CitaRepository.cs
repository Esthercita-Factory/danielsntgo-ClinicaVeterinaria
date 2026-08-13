using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class CitaRepositories
{
    public List<Cita> Citas { get; set; }
    
    public CitaRepositories(List<Mascota> mascotas)
    {
        Citas = new List<Cita>()
        {
            new Cita("control anual", new DateTime(2026, 8, 15, 9, 0, 0),EstadoCita.Confirmada,TipoServicio.ConsultaGeneral,mascotas[0]),
            new Cita("vacunacion", new DateTime(2026, 8, 16, 10, 30, 0),EstadoCita.Pendiente,TipoServicio.Vacunacion,mascotas[1]),
            new Cita("desparasitacion", new DateTime(2026, 8, 17, 11, 0, 0),EstadoCita.Pendiente,TipoServicio.ConsultaGeneral,mascotas[2]),
            new Cita("revision de peso", new DateTime(2026, 8, 18, 14, 0, 0),EstadoCita.Confirmada,TipoServicio.ConsultaGeneral,mascotas[3]),
            new Cita("consulta general", new DateTime(2026, 8, 19, 8, 30, 0),EstadoCita.Cancelado,TipoServicio.ConsultaGeneral,mascotas[4]),
            new Cita("limpieza dental", new DateTime(2026, 8, 20, 15, 0, 0),EstadoCita.Pendiente,TipoServicio.ConsultaGeneral,mascotas[5]),
            new Cita("control anual", new DateTime(2026, 8, 21, 9, 30, 0),EstadoCita.Confirmada,TipoServicio.ConsultaGeneral,mascotas[6]),
        };
    }
}