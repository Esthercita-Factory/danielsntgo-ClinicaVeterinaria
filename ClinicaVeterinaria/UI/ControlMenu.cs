using ClinicaVeterinaria.models;
using ClinicaVeterinaria.Repositories;
using ClinicaVeterinaria.Services;

namespace ClinicaVeterinaria.UI;

public static class ControlMenu
{
    public static void Iniciar()
    {       
        string opcion;
        do
        {
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Listar pacientes");
            Console.WriteLine("3. Consultar paciente");
            Console.WriteLine("4. Salir");
            
            Console.Write("Seleccione una opcion: ");
            opcion = Console.ReadLine().Trim();
            
            
            switch (opcion)
            {
              case "1": 
                  RegistrarDesdeConsola();
                  break;
              case "2":
                  ListarDesdeConsola();
                  break;
              case "3": 
                  BuscarDesdeConsola();
                  break;
              case "4":
                  Console.WriteLine("Saliendo del sistema ");
                  break;
              default:  
                  Console.WriteLine("Opcion invalida. Porfavor ingresar un numero del 1 al 4");
                  break;
            }
        } while (opcion != "4");
    }

    public static void RegistrarDesdeConsola()
    {
        try
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine().Trim().ToLower();
            
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.Write("Raza: ");
            string raza = Console.ReadLine().Trim().ToLower();

            Console.Write("Síntomas: ");
            string sintomas = Console.ReadLine().Trim().ToLower();

            Paciente nuevoPaciente = new Paciente(nombre, edad, peso, raza, sintomas);

            PacienteServices.RegistrarPaciente(nuevoPaciente);
            Console.WriteLine("Paciente registrado con éxito.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: edad y peso deben ser números enteros válidos.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrio un error inesperado: {ex.Message}");
        }
    }

    public static void BuscarDesdeConsola()
    {
        try
        {
            Console.WriteLine("Ingrese nombre a buscar: ");
            string nombre = Console.ReadLine().Trim().ToLower();
            var paciente = PacienteServices.BuscarPaciente(nombre);
            if (paciente != null)
                MostrarPaciente(paciente);
            else
            {
                Console.WriteLine("No se encontro  ningun paciente con ese nombre.");
            }

        }
        
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
       
    }

    public static void ListarDesdeConsola()
    {
        List<Paciente> pacientes = PacienteServices.MostrarPacienteListos();
        if (pacientes.Count == 0)
        {
            Console.WriteLine("No hay pacientes registrados.");
            return;
        }

        foreach (var i in pacientes)
        {
            MostrarPaciente(i);
        }
    }
    public static void MostrarPaciente(Paciente paciente)
    {
        Console.WriteLine($"Paciente: {paciente.Id}");
        Console.WriteLine($"Nombre: {paciente.Nombre}");
        Console.WriteLine($"Edad: {paciente.Edad}");
        Console.WriteLine($"Raza: {paciente.Raza}");
        Console.WriteLine($"Sintomas: {paciente.Sintomas}");
    }
}

