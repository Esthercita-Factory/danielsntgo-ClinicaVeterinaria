namespace ClinicaVeterinaria.models;

public class Cita : Mascota
{
        public Guid Id { get; set; }
        public DateTime FechaCita { get; set; }
        public string MotivoCita { get; set; }
        public enum EstadoCita
        {
               Pendiente = 1,
               Confirmada = 2,
               Cancelado = 3
        }
}