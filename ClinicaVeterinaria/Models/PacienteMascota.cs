namespace ClinicaVeterinaria.models;

public class PacienteMascota
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Peso { get; set; }
    public string? Raza { get; set; }
    public string? Sintomas { get; set; }
    public Guid? DuenoId { get; set; }

    public PacienteMascota(string nombre, int edad, int peso, string raza, string sintomas)
    {
        Id = Guid.NewGuid();
        Nombre = nombre.Trim().ToLower();
        Edad = edad;
        Peso = peso;
        Raza = raza.Trim().ToLower();
        Sintomas = sintomas.Trim().ToLower();
    }
}


