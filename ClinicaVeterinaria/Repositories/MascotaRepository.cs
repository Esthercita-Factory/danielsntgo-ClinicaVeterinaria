using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class MascotaRepositories : ICrudOperations<Mascota>
{
    public static List<Mascota> Mascotas { get; set; }

    public MascotaRepositories(List<Tutor> tutores)
    {
        Mascotas = new List<Mascota>()
        {
            new Mascota( "rocky",  3,  28,  "canino",  "labrador", null),
            new Mascota( "michi",  2,  4,  "feline",  "siames", null),
            new Mascota( "toby", 5,  15, "canino",  "beagle", tutores[2]),
            new Mascota( "luna",  1,  3,  "feline",  "persa", tutores[3]),
            new Mascota( "max",  7,  32,  "canino",  "pastor aleman", null),
            new Mascota( "nina",  4,   5,  "canino",  "criollo", tutores[4]),
            new Mascota("coco",  2,  2,  "canino",  "chihuahua", null),
            new Mascota( "bella",  3,  22,  "canino",  "golden retriever", tutores[6]),
            new Mascota( "oreo",  1,  4,  "canino",  "mestizo", tutores[5])

        };
    }

    public void Registrar(Mascota mascota) => Mascotas.Add(mascota);

    public List<Mascota> Buscar() => Mascotas;

    public void Actualizar(Mascota entidad)
    {
        // modificar todos  los metodos acrualizar
        var existente = Mascotas.Find(m => m.Id == entidad.Id);
        if (existente != null)
        {
            existente.Nombre = entidad.Nombre;
            existente.Edad = entidad.Edad;
            existente.Peso = entidad.Peso;
            existente.Especie = entidad.Especie;
            existente.Raza = entidad.Raza;
            existente.Tutor = entidad.Tutor;
        }
    }

    public void Eliminar(Mascota mascota) => Mascotas.Remove(mascota);

    public void Asignar(Mascota mascota, object tutor)
    {
        mascota.Tutor = (Tutor)tutor;
        Mascotas.Add(mascota);
    } 
}