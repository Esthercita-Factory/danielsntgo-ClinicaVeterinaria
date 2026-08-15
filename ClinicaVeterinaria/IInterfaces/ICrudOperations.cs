namespace ClinicaVeterinaria.IInterfaces;

public interface ICrudOperations<T>
{
    void Registrar(T entidad);
    List<T> Buscar();
    void Actualizar();
    void Eliminar();
    void Asignar();
}