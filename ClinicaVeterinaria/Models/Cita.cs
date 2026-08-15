using ClinicaVeterinaria.Enums;

namespace ClinicaVeterinaria.models;

public class Cita 
{
        public Guid Id { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }
        public TipoServicio Servicio { get; set; }
        public EstadoCita Estado { get; set; }
        public Mascota Mascota { get; set; }
        
        public Cita(string motivo,
                    DateTime fecha,
                    TipoServicio servicio,
                    EstadoCita estado,
                    Mascota mascota)
        {
            Id = Guid.NewGuid();   
            Motivo = motivo.Trim().ToLower();
            Fecha = fecha;
            Servicio = servicio;
            Estado = estado;
            Mascota = mascota;
            
        }
}