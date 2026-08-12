using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public  static class DuenoMascotaRepositories
{ 
    public static List<Tutor> Duenos { get; set; }

    static DuenoMascotaRepositories()
    {
        Duenos = new List<Tutor>()
        {
            new Tutor("carlos ramirez", "3001234567", "1020304050"),
            new Tutor("maria gonzalez", "3009876543", "1030405060"),
            new Tutor("andres lopez",   "3112345678", "1040506070"),
            new Tutor("laura martinez", "3123456789", "1050607080"),
            new Tutor("juan perez",     "3134567890", "1060708090"),
            new Tutor("sofia castro",   "3145678901", "1070809010"),
            new Tutor("diego rojas",    "3156789012", "1080901020")
        };
    }
    // public static void RegistraDuenos(DuenoMascota duenoRegistrado)
    // {
    //     Duenos.Add(duenoRegistrado);
    // }
    //
    // public static List<DuenoMascota> ListarDuenoMascotas()
    // {
    //     return Duenos;
    // }
    //
    // public static DuenoMascota? BuscarDuenoPorNormbre(string nombre)
    // {
    //     return Duenos.FirstOrDefault(c => c.NombreDueno.Equals(nombre,StringComparison.OrdinalIgnoreCase));
    // }
    

}
