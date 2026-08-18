namespace ClinicaVeterinaria.IInterfaces;

public interface ICrudOperations<T>
{
    void Registrar(T entidad);
    List<T> Buscar();
    void Actualizar(T entidad);
    void Eliminar(T entidad);
    void Asignar(T entidad1, object entidad2);
}