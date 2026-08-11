namespace ClinicaVeterinaria.models;

public class Mascota
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Peso { get; set; }
    public string? Raza { get; set; }
    public Guid? DuenoId { get; set; }
    
    
}