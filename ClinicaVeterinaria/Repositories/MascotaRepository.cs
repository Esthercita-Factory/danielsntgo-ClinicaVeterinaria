using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.IInterfaces;
using ClinicaVeterinaria.models;

namespace ClinicaVeterinaria.Repositories;

public class MascotaRepositories : IMascotaRepository
{
    private readonly List<Mascota> _mascotas;

    public MascotaRepositories(Almacen almacen)
    {
        _mascotas = almacen.Mascotas;
    }

    public void  Registrar(Mascota mascota) => _mascotas.Add(mascota);

    public List<Mascota> Buscar() => _mascotas;

    public void Actualizar(Mascota mascota)
    {
        mascota.Nombre = mascota.Nombre;
        mascota.Edad =  mascota.Edad;
        mascota.Peso = mascota.Peso;
        mascota.Especie = mascota.Especie;
        mascota.Raza = mascota.Raza;
    }

    public void Eliminar(Mascota mascota) => _mascotas.Remove(mascota);
    
    public void Asignar(Mascota mascota, object tutor) => mascota.Tutor = (Tutor)tutor;
    
    public void desasignar(Mascota mascota, object Tutor) =>  mascota.Tutor = null;
}