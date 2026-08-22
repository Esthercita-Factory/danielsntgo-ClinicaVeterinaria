using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class TutorRepositories : ITutorRepository
{
    private List<Tutor> _tutores;

    public TutorRepositories(Almacen almacen)

    {
        _tutores = almacen.Tutores;
    }

    public void Registrar(Tutor tutor) => _tutores.Add(tutor);

    public List<Tutor> obtenerTodos() => _tutores;
    public List<Tutor> BuscarPorCC(string nome) => _tutores;
    public List<Tutor> BuscarPorNombre(string nombre) => _tutores;
    public List<Mascota> obtenerMascotas(Tutor tutor) => tutor.Mascotas;

    public void Actualizar(Tutor tutor)
    {
        tutor.Nombre = tutor.Nombre;
        tutor.CC = tutor.CC;
        tutor.Telefono = tutor.Telefono;
        tutor.Email = tutor.Email;
    }

    public void Eliminar(Tutor tutor) => _tutores.Remove(tutor);

    public void Asignar(Tutor tutor, object mascota) => tutor.Mascotas.Add((Mascota)mascota);
    public void desasignar(Tutor tutor, object mascota) => tutor.Mascotas.Remove((Mascota)mascota);
   
}