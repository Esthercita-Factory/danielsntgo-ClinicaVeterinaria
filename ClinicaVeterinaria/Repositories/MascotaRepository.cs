using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class MascotaRepositories
{
    public List<Mascota> Mascotas { get; set; }

    public MascotaRepositories(List<Tutor> tutores)
    {
        Mascotas = new List<Mascota>()
        {
            new Mascota( "rocky",  3,  28,  "labrador",  null),
            new Mascota( "michi",  2,  4,  "siames",  null),
            new Mascota( "toby", 5,  15, "beagle",  tutores[2]),
            new Mascota( "luna",  1,  3,  "persa", tutores[3]),
            new Mascota( "max",  7,  32,  "pastor aleman", null),
            new Mascota( "nina",  4,   5,  "criollo",  tutores[4]),
            new Mascota("coco",  2,  2,  "chihuahua", null),
            new Mascota( "bella",  3,  22,  "golden retriever",  tutores[6]),
            new Mascota( "oreo",  1,  4,  "mestizo",  tutores[5])

        };
    }
}