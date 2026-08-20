using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Data;

public class Almacen
{
    public List<Mascota> Mascotas { get; set; } = [];
    public List<Tutor> Tutorses { get; set; } = [];
    public List<Cita>  Citas { get; set; } = [];
}