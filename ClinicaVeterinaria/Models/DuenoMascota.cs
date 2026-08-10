namespace ClinicaVeterinaria.models;

public  class DuenoMascota
{
    
        public Guid Id { get; set; }
        public string NombreDueno { get; set; }
        public int TelefonoDueno { get; set; }
        public List<PacienteMascota>  Mascotas { get; set; }
        public Guid? DuenoId { get; set; }
    public DuenoMascota(string nombreDueno, int telefonoDueno, List<PacienteMascota> mascotas)
    {
        Id = Guid.NewGuid();
        NombreDueno =  nombreDueno.ToLower();
        TelefonoDueno = telefonoDueno;
        Mascotas = new List<PacienteMascota>();
    }
    
   
}