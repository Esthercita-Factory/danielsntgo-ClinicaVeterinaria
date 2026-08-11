namespace ClinicaVeterinaria.models;

public  class DuenoMascota
{
    
        public Guid Id { get; set; }
        public string NombreDueno { get; set; }
        public string TelefonoDueno { get; set; }
        public List<PacienteMascota>  Mascotas { get; set; }
        
    public DuenoMascota(string nombreDueno, string telefonoDueno)
    {
        Id = Guid.NewGuid();
        NombreDueno =  nombreDueno.Trim().ToLower();
        TelefonoDueno = telefonoDueno.Trim();
        Mascotas = new List<PacienteMascota>();
    }
    
   
}   