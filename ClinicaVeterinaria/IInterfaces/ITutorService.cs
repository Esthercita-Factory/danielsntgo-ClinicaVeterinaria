using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.IInterfaces;

public interface ITutorService
{
    void Registrar(Tutor tutor);
    List<Tutor> obtenerTodos();
    List<Tutor> BuscarPorCC(string cc);
    List<Tutor> BuscarPorNombre(string nombre);
    List<Mascota> obtenerMascotas(Tutor tutor);
    void Actualizar(Tutor tutor);
    void Eliminar(Tutor tutor);
    void Asignar(Tutor tutor, object mascota) ;
    void desasignar(Tutor tutor, object mascota);
}