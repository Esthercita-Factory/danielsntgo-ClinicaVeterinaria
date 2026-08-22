using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Data;

public class Almacen
{
    public List<Tutor> Tutores { get; set; } = new List<Tutor>();
    public List<Mascota> Mascotas { get; set; } = new List<Mascota>();
    public List<Cita> Citas { get; set; } = new List<Cita>();

   
    public Almacen()
    {
        Tutores = new List<Tutor>
        {
            new Tutor("carlos ramirez", "1020304050", "3001234567", "carlos@email.com"),
            new Tutor("maria gonzalez", "1030405060", "3009876543", "maria@email.com"),
            new Tutor("andres lopez", "1040506070", "3112345678", "andres@email.com"),
            new Tutor("laura martinez", "1050607080", "3123456789", "laura@email.com"),
            new Tutor("juan perez", "1060708090", "3134567890", "juan@email.com"),
            new Tutor("sofia castro", "1070809010", "3145678901", "sofia@email.com"),
            new Tutor("diego rojas", "1080901020", "3156789012", "diego@email.com")
        };
        Mascotas = new List<Mascota>
        {
            new Mascota("rocky", 3, 28, "canino", "labrador", null),
            new Mascota("michi", 2, 4, "feline", "siames", null),
            new Mascota("toby", 5, 15, "canino", "beagle", Tutores[2]),
            new Mascota("luna", 1, 3, "feline", "persa", Tutores[3]),
            new Mascota("max", 7, 32, "canino", "pastor aleman", null),
            new Mascota("nina", 4, 5, "canino", "criollo", Tutores[4]),
            new Mascota("coco", 2, 2, "canino", "chihuahua", null),
            new Mascota("bella", 3, 22, "canino", "golden retriever", Tutores[4]),
            new Mascota("oreo", 1, 4, "canino", "mestizo", Tutores[5])
        };
        Citas = new List<Cita>
        {
            new Cita("control anual", new DateTime(2026, 8, 15, 9, 0, 0), TipoServicio.ConsultaGeneral, EstadoCita.Confirmada, Mascotas[0]),
            new Cita("vacunacion", new DateTime(2026, 8, 10, 10, 30, 0), TipoServicio.Vacunacion, EstadoCita.Pendiente, Mascotas[1]),
            new Cita("desparasitacion", new DateTime(2026, 8, 17, 11, 0, 0), TipoServicio.ConsultaGeneral, EstadoCita.Pendiente, Mascotas[2]),
            new Cita("revision de peso", new DateTime(2026, 8, 18, 14, 0, 0), TipoServicio.ConsultaGeneral, EstadoCita.Confirmada, Mascotas[3]),
            new Cita("consulta general", new DateTime(2026, 8, 19, 8, 30, 0), TipoServicio.ConsultaGeneral, EstadoCita.Cancelado, Mascotas[4]),
            new Cita("limpieza dental", new DateTime(2026, 8, 20, 15, 0, 0), TipoServicio.ConsultaGeneral, EstadoCita.Pendiente, Mascotas[5]),
            new Cita("control anual", new DateTime(2026, 8, 21, 9, 30, 0), TipoServicio.ConsultaGeneral, EstadoCita.Confirmada, Mascotas[6])
        };
    }
}