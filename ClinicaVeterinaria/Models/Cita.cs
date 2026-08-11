namespace ClinicaVeterinaria.models;

public class Cita 
{
        public Guid Id { get; set; }
        public DateTime FechaCita { get; set; }
        public string MotivoCita { get; set; }
        public PacienteMascota Mascota { get; set; }
        public enum EstadoCita
        {
               Pendiente = 1,
               Confirmada = 2,
               Cancelado = 3
        }
        public Cita(string motivoCita, DateTime fechaCita, PacienteMascota mascota, EstadoCita estadoCita)
        {
            Id = Guid.NewGuid();   
            FechaCita = DateTime.Now;
            MotivoCita = motivoCita.Trim().ToLower();
            Mascota = mascota;
            
        }
}