namespace ClinicaVeterinaria.models;

public class Mascota
{
    public Guid Id { get; private set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Peso { get; set; }
    public string Especie { get; set; }
    public string Raza { get; set; }
    public Tutor? Tutor { get; set; }
    public List<Cita> Citas { get; set; } = [];
    
    public Mascota(string nombre,
                   int edad,
                   int peso,
                   string especie,
                   string raza,
                   Tutor? tutor)
    {
        Id = Guid.NewGuid();
        Nombre = nombre.Trim().ToLower();
        Edad = edad;
        Peso = peso;
        Especie = especie.Trim().ToLower();
        Raza = raza.Trim().ToLower();
        Tutor = tutor;
        Citas = new List<Cita>();
    }
}


