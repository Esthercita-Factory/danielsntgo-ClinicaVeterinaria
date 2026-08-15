using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public  static class TutorRepositories
{ 
    public static List<Tutor> Tutores { get; set; }

    static TutorRepositories()
    {
        Tutores = new List<Tutor>()
        {
            new Tutor("carlos ramirez", "1020304050", "3001234567", "carlos@email.com"),
            new Tutor("maria gonzalez", "1030405060", "3009876543", "maria@email.com"),
            new Tutor("andres lopez",   "1040506070", "3112345678", "andres@email.com"),
            new Tutor("laura martinez", "1050607080", "3123456789", "laura@email.com"),
            new Tutor("juan perez",     "1060708090", "3134567890", "juan@email.com"),
            new Tutor("sofia castro",   "1070809010", "3145678901", "sofia@email.com"),
            new Tutor("diego rojas",    "1080901020", "3156789012", "diego@email.com")
        };
    }
    
    public static void Registrar(Tutor tutor) => Tutores.Add(tutor);

    public static List<Tutor> Buscar() => Tutores;

    public static void Actualizar() { }

    public static void Eliminar() { }

    public static void Asignar(Tutor tutor, Mascota mascota) => tutor.Mascotas.Add(mascota);
    
}