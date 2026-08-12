namespace ClinicaVeterinaria.models;

public class PacienteMascota
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Peso { get; set; }
    public string? Raza { get; set; }
    public Tutor? Dueno { get; set; }

    public PacienteMascota(string nombre, int edad, int peso, string raza, Tutor? dueno)
    {
        Id = Guid.NewGuid();
        Nombre = nombre.Trim().ToLower();
        Edad = edad;
        Peso = peso;
        Raza = raza.Trim().ToLower();
        Dueno = dueno;
        
    }
}


