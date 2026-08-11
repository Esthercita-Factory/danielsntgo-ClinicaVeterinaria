using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public static class PacienteMascotaRepositories
{
    public static List<PacienteMascota> Pacientes { get; set; }

    static PacienteMascotaRepositories()
    {
        Pacientes = new List<PacienteMascota>()
        {
            new PacienteMascota("rocky", 3, 28, "labrador", "vomito y diarrea"),
            new PacienteMascota("michi", 2, 4, "siames", "estornudos frecuentes"),
            new PacienteMascota("toby", 5, 15, "beagle", "cojera en pata trasera"),
            new PacienteMascota("luna", 1, 3, "persa", "falta de apetito"),
            new PacienteMascota("max", 7, 32, "pastor aleman", "letargo y fiebre"),
            new PacienteMascota("nina", 4, 6, "poodle", "picazon excesiva"),
            new PacienteMascota("simon", 6, 5, "criollo", "herida en pata delantera"),
            new PacienteMascota("coco", 2, 2, "chihuahua", "tos persistente"),
            new PacienteMascota("bella", 3, 22, "golden retriever", "revision de rutina"),
            new PacienteMascota("oreo", 1, 4, "mestizo", "vacunacion anual")

        };
    }
    public static void RegistrarPaciente(PacienteMascota pacienteRegistrado)
    {
        Pacientes.Add(pacienteRegistrado);
    }

    public static List<PacienteMascota> ListarPacientes()
    {
        return Pacientes;
    }

    public static PacienteMascota? buscarPacientePorNombre(string nombre)
    {
      return Pacientes.FirstOrDefault(c => c.Nombre.Equals(nombre,StringComparison.OrdinalIgnoreCase));
    }
    public static void AsignarDuenosDePrueba()
    {
        var duenos = DuenoMascotaRepositories.Duenos;

        AsignarDueno(Pacientes[0], duenos[0]);
        AsignarDueno(Pacientes[1], duenos[1]);
        AsignarDueno(Pacientes[2], duenos[2]);
        AsignarDueno(Pacientes[3], duenos[3]);
        AsignarDueno(Pacientes[4], duenos[0]);
        AsignarDueno(Pacientes[5], duenos[4]);
        AsignarDueno(Pacientes[6], duenos[4]);
    }

    public static void AsignarDueno(PacienteMascota mascota, DuenoMascota dueno)
    {
        mascota.DuenoId = dueno.Id;
        dueno.Mascotas.Add(mascota);
    }

    
}