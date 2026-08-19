namespace ClinicaVeterinaria.models;

public  class Tutor
{
    
        public Guid Id { get; private set; }
        public string Nombre { get; set; }
        public string  CC { get;  set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Mascota>  Mascotas { get; set; }
        
    public Tutor(string nombre,
                 string cc,
                 string telefono,
                 string email)
    {
        Id = Guid.NewGuid();
        Nombre =  nombre.Trim().ToLower();
        CC = cc.Trim().Replace(" ", "");
        Telefono = telefono.Trim().Replace(" ", "");
        Email = email.Trim().Replace(" ", "");
        Mascotas = new List<Mascota>();
    }
}    