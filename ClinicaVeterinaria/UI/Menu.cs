using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.models;
using ClinicaVeterinaria.Repositories;
using ClinicaVeterinaria.Services;

namespace ClinicaVeterinaria.UI;

public static class ControlMenu
{
    // private MascotaServices _mascotaService;
    // private CitaServices _citaService;
    // private TutorService _tutorService;
    //
    // static ControlMenu()
    // {
    //     var almacen = new ClinicaVeterinaria.Data.Almacen();
    //     var mascotaRepository = new ClinicaVeterinaria.Repositories.MascotaRepositories(almacen);
    //     var citaRepository = new ClinicaVeterinaria.Repositories.CitaRepository(almacen);
    //     var tutorRepository = new ClinicaVeterinaria.Repositories.TutorRepositories(almacen);
    //
    //     _mascotaService = new MascotaServices(mascotaRepository);
    //     _citaService = new CitaServices(citaRepository);
    //     _tutorService = new TutorService(tutorRepository);
    // }
    //
    public static void Iniciar()
    {
        int opcion;
        do
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
    
            // Menú principal de 4 opciones
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  CLÍNICA VETERINARIA - MENÚ PRINCIPAL            ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  [1] Administración de Mascotas                                  ║");
            Console.WriteLine("║  [2] Administración de Citas                                     ║");
            Console.WriteLine("║  [3] Administración de Tutores                                   ║");
            Console.WriteLine("║  [4] Salir del Sistema                                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
    
            Console.Write("Seleccione una opción (1-4): ");
            opcion = int.Parse(Console.ReadLine());
    
            switch (opcion)
            {
                case 1:
                    MenuMascotas(); 
                    break;
                case 2:
                    MenuCitas();
                    break;
                case 3:
                    MenuTutores();
                    break;
                case 4:
                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                          ¡Hasta luego!                           ║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor ingrese un número del 1 al 4.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }
        } while (opcion != 4);
    }
    
    // // // Método auxiliar para validar entrada numérica
    // private static int GetValidInput(int min, int max)
    // {
    //     int input;
    //     while (!int.TryParse(Console.ReadLine(), out input) || input < min || input > max)
    //     {
    //         Console.WriteLine("Entrada inválida. Ingrese un número del " + min + " al " + max + ": ");
    //     }
    //     return input;
    // }
    //
    // #region Menú de Mascotas
    private static void MenuMascotas()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               CLÍNICA VETERINARIA - MASCOTAS                    ║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  [1] Registrar nueva mascota                                    ║");
            Console.WriteLine("║  [2] Listar todas las mascotas                                  ║");
            Console.WriteLine("║  [3] Buscar mascota por nombre                                  ║");
            Console.WriteLine("║  [4] Buscar mascota por especie                                 ║");
            Console.WriteLine("║  [5] Buscar mascota por raza                                    ║");
            Console.WriteLine("║  [0] Volver al menú principal                                   ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
    
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());
            ;
    
            switch (opcion)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
            }
        } while (opcion != 0);
    }
    
    // private static void RegistrarMascota()
    // {
    //     Console.Write("\nNombre: ");
    //     string nombre = Console.ReadLine().Trim().ToLower();
    //
    //     Console.Write("Edad: ");
    //     int edad = int.Parse(Console.ReadLine());
    //
    //     Console.Write("Peso: ");
    //     int peso = int.Parse(Console.ReadLine());
    //
    //     Console.Write("Raza: ");
    //     string raza = Console.ReadLine().Trim().ToLower();
    //
    //     Console.Write("Especie: ");
    //     string especie = Console.ReadLine().Trim().ToLower();
    //
    //     var nuevaMascota = new Mascota(nombre, edad, peso, especie, raza, null);
    //     _mascotaService.Registrar(nuevaMascota);
    //     Console.WriteLine("\n[OK] Mascota registrada con éxito.");
    //     Console.WriteLine("Presione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void ListarMascotas()
    // {
    //     var mascotas = _mascotaService.obtenerTodos();
    //     if (mascotas.Count == 0)
    //     {
    //         Console.WriteLine("\n[ADVERTENCIA] No hay mascotas registradas.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("\n[" + mascotas.Count + "] Lista de mascotas registradas:");
    //         foreach (var m in mascotas)
    //         {
    //             string tutor = m.Tutor != null ? m.Tutor.Nombre : "Sin tutor";
    //             Console.WriteLine("• " + m.Nombre + " - " + m.Especie + "/" + m.Raza + ", " + m.Edad + " años, Peso: " + m.Peso + " kg (Tutor: " + tutor + ")");
    //         }
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarMascotaNombre()
    // {
    //     Console.Write("\nNombre a buscar: ");
    //     string nombre = Console.ReadLine().Trim().ToLower();
    //     var mascotas = _mascotaService.obtenerPorNombre(nombre);
    //
    //     if (mascotas.Any())
    //     {
    //         var m = mascotas.First();
    //         Console.WriteLine("\n[OK] Mascota encontrada:");
    //         Console.WriteLine("   Nombre: " + m.Nombre);
    //         Console.WriteLine("   Especie: " + m.Especie);
    //         Console.WriteLine("   Raza: " + m.Raza);
    //         Console.WriteLine("   Edad: " + m.Edad + " años");
    //         Console.WriteLine("   Peso: " + m.Peso + " kg");
    //         Console.WriteLine("   Tutor: " + (m.Tutor != null ? m.Tutor.Nombre : "Sin tutor"));
    //     }
    //     else
    //     {
    //         Console.WriteLine(" No se encontró ninguna mascota con ese nombre.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarMascotaEspecie()
    // {
    //     Console.Write("\nEspecie a buscar (ej. perro, gato, ave): ");
    //     string especie = Console.ReadLine().Trim().ToLower();
    //     var mascotas = _mascotaService.obtenerPorEspecie(especie);
    //
    //     if (mascotas.Any())
    //     {
    //         Console.WriteLine("\n[OK] Mascotas de especie '" + especie.ToUpper() + "':");
    //         foreach (var m in mascotas)
    //         {
    //             Console.WriteLine("• " + m.Nombre + " - Raza: " + m.Raza + ", Edad: " + m.Edad + " años");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No se encontraron mascotas de especie '" + especie.ToUpper() + "'.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarMascotaRaza()
    // {
    //     Console.Write("\nRaza a buscar (ej. labrador, siamés, persa): ");
    //     string raza = Console.ReadLine().Trim().ToLower();
    //     var mascotas = _mascotaService.obtenerPorRaza(raza);
    //
    //     if (mascotas.Any())
    //     {
    //         Console.WriteLine("\n[OK] Mascotas de raza '" + raza.ToUpper() + "':");
    //         foreach (var m in mascotas)
    //         {
    //             Console.WriteLine("• " + m.Nombre + " - Especie: " + m.Especie + ", Edad: " + m.Edad + " años");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No se encontraron mascotas de raza '" + raza.ToUpper() + "'.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    // #endregion
    //
    // #region Menú de Citas
    private static void MenuCitas()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║          CLÍNICA VETERINARIA - ADMINISTRACIÓN DE CITAS          ║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  [1] Registrar nueva cita                                       ║");
            Console.WriteLine("║  [2] Listar todas las citas                                     ║");
            Console.WriteLine("║  [3] Buscar cita por fecha                                      ║");
            Console.WriteLine("║  [4] Buscar cita por estado                                     ║");
            Console.WriteLine("║  [5] Buscar cita por tipo de servicio                           ║");
            Console.WriteLine("║  [0] Volver al menú principal                                   ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
    
            Console.Write("Opción: ");
            opcion =  int.Parse(Console.ReadLine());
    
            switch (opcion)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                   
                    break;
                case 5:
                    
                    break;
            }
        } while (opcion != 0);
    }
    //
    // private static void RegistrarCita()
    // {
    //     Console.Write("\nMotivo de la cita: ");
    //     string motivo = Console.ReadLine().Trim().ToLower();
    //
    //     Console.Write("Fecha (dd/MM/yyyy): ");
    //     DateTime fecha = DateTime.Parse(Console.ReadLine());
    //
    //     Console.Write("Tipo de servicio (1-ConsultaGeneral, 2-Vacunacion): ");
    //     int servicioNum = int.Parse(Console.ReadLine());
    //     TipoServicio servicio = servicioNum == 1 ? TipoServicio.ConsultaGeneral : TipoServicio.Vacunacion;
    //
    //     Console.Write("Estado (1-Confirmada, 2-Pendiente, 3-Cancelado): ");
    //     int estadoNum = int.Parse(Console.ReadLine());
    //     EstadoCita estado = estadoNum == 1 ? EstadoCita.Confirmada : estadoNum == 2 ? EstadoCita.Pendiente : EstadoCita.Cancelado;
    //
    //     // Buscar una mascota disponible (usamos la primera de la lista)
    //     var mascotas = _mascotaService.obtenerTodos();
    //     var mascota = mascotas.FirstOrDefault() != null ? mascotas.First() : new Mascota("Sin nombre", 0, 0, "desconocido", "desconocido", null);
    //
    //     var nuevaCita = new Cita(motivo, fecha, servicio, estado, mascota);
    //     _citaService.Registrar(nuevaCita);
    //     Console.WriteLine("\n[OK] Cita registrada con éxito.");
    //     Console.WriteLine("Presione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void ListarCitas()
    // {
    //     // Accedemos al servicio para listar todas
    //     var todasLasCitas = _citaService.ObtenerTodos();
    //
    //     if (todasLasCitas.Count == 0)
    //     {
    //         Console.WriteLine("\n[ADVERTENCIA] No hay citas registradas.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("\n[" + todasLasCitas.Count + "] Lista de citas registradas:");
    //         foreach (var c in todasLasCitas)
    //         {
    //             string mascotaNombre = c.Mascota != null ? c.Mascota.Nombre : "Sin mascota";
    //             Console.WriteLine("• Fecha: " + c.Fecha.ToShortDateString());
    //             Console.WriteLine("   Mascota: " + mascotaNombre);
    //             Console.WriteLine("   Motivo: " + c.Motivo);
    //             Console.WriteLine("   Servicio: " + c.Servicio);
    //             Console.WriteLine("   Estado: " + c.Estado);
    //             Console.WriteLine("---");
    //         }
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarCitaFecha()
    // {
    //     Console.Write("\nFecha a buscar (dd/MM/yyyy): ");
    //     string fechaStr = Console.ReadLine();
    //     if (DateTime.TryParse(fechaStr, out DateTime fecha))
    //     {
    //         var citas = _citaService.ObtenerPorFecha(fecha);
    //         if (citas.Any())
    //         {
    //             Console.WriteLine("\n[OK] Citas del " + fecha.ToShortDateString() + ":");
    //             foreach (var c in citas)
    //             {
    //                 Console.WriteLine("• " + c.Mascota?.Nombre + ": " + c.Motivo + " - " + c.Estado);
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine(" No hay citas programadas para esa fecha.");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Formato de fecha inválido.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarCitaEstado()
    // {
    //     Console.Write("\nEstado a buscar (1-Confirmada, 2-Pendiente, 3-Cancelada): ");
    //     int estadoNum = int.Parse(Console.ReadLine());
    //     EstadoCita estado = estadoNum == 1 ? EstadoCita.Confirmada : estadoNum == 2 ? EstadoCita.Pendiente : EstadoCita.Cancelado;
    //
    //     var citas = _citaService.ObtenerPorEstadoCita(estado);
    //
    //     if (citas.Any())
    //     {
    //         Console.WriteLine("\n[OK] Citas con estado '" + estado + "':");
    //         foreach (var c in citas)
    //         {
    //             Console.WriteLine("• " + c.Mascota?.Nombre + ": " + c.Motivo + " - Fecha: " + c.Fecha.ToShortDateString());
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine(" No hay citas con ese estado.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarCitaServicio()
    // {
    //     Console.Write("\nTipo de servicio (1-ConsultaGeneral, 2-Vacunacion): ");
    //     int servicioNum = int.Parse(Console.ReadLine());
    //     TipoServicio servicio = servicioNum == 1 ? TipoServicio.ConsultaGeneral : TipoServicio.Vacunacion;
    //
    //     var citas = _citaService.ObtenerPorServicio(servicio);
    //
    //     if (citas.Any())
    //     {
    //         Console.WriteLine("\n[OK] Citas de tipo '" + servicio + "':");
    //         foreach (var c in citas)
    //         {
    //             Console.WriteLine("• " + c.Mascota?.Nombre + ": " + c.Motivo + " - Fecha: " + c.Fecha.ToShortDateString());
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No hay citas de ese tipo de servicio.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    // #endregion
    //
    // #region Menú de Tutores
    private static void MenuTutores()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║             CLÍNICA VETERINARIA - ADMINISTRACIÓN DE TUTORES      ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  [1] Listar todos los tutores                                    ║");
            Console.WriteLine("║  [2] Buscar tutor por número de CC                               ║");
            Console.WriteLine("║  [3] Buscar tutor por nombre                                     ║");
            Console.WriteLine("║  [4] Ver mascotas de un tutor                                    ║");
            Console.WriteLine("║  [5] Registrar nuevo tutor                                       ║");
            Console.WriteLine("║  [0] Volver al menú principal                                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
    
            Console.Write("Opción: ");
            opcion =  int.Parse(Console.ReadLine());
    
            switch (opcion)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
            }
        } while (opcion != 0);
    }
    //
    // private static void ListarTutores()
    // {
    //     var tutores = _tutorService.obtenerTodos();
    //
    //     if (tutores.Count == 0)
    //     {
    //         Console.WriteLine("\n[ADVERTENCIA] No hay tutores registrados.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("\n[" + tutores.Count + "] Lista de tutores registrados:");
    //         foreach (var t in tutores)
    //         {
    //             string mascotasTxt = t.Mascotas.Count > 0 ? t.Mascotas.Count + " mascota(s)" : "Sin mascotas";
    //             Console.WriteLine("• " + t.Nombre + " - CC: " + t.CC);
    //             Console.WriteLine("   Tel: " + t.Telefono + " | Mail: " + t.Email);
    //             Console.WriteLine("   Mascotas: " + mascotasTxt);
    //         }
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarTutorCC()
    // {
    //     Console.Write("\nNúmero de CC a buscar: ");
    //     string cc = Console.ReadLine().Trim();
    //
    //     var tutores = _tutorService.BuscarPorCC(cc);
    //
    //     if (tutores.Any())
    //     {
    //         Console.WriteLine("\n[OK] Tutor(es) con CC '" + cc + "':");
    //         foreach (var t in tutores)
    //         {
    //             Console.WriteLine("• " + t.Nombre + " - Tel: " + t.Telefono + " | Mail: " + t.Email);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No se encontró ningún tutor con CC '" + cc + "'.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void BuscarTutorNombre()
    // {
    //     Console.Write("\nNombre de tutor a buscar: ");
    //     string nombre = Console.ReadLine().Trim();
    //
    //     var tutores = _tutorService.BuscarPorNombre(nombre);
    //
    //     if (tutores.Any())
    //     {
    //         Console.WriteLine("\n[OK] Tutor(es) con nombre '" + nombre + "':");
    //         foreach (var t in tutores)
    //         {
    //             Console.WriteLine("• " + t.Nombre + " - CC: " + t.CC + " | Tel: " + t.Telefono);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No se encontró ningún tutor con nombre '" + nombre + "'.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void VerMascotasTutor()
    // {
    //     Console.Write("\nNombre o CC del tutor: ");
    //     string busqueda = Console.ReadLine().Trim();
    //
    //     // Intentar buscar por CC primero, si no por nombre
    //     var tutores = _tutorService.BuscarPorCC(busqueda);
    //     if (!tutores.Any())
    //     {
    //         tutores = _tutorService.BuscarPorNombre(busqueda);
    //     }
    //
    //     if (tutores.Any())
    //     {
    //         var t = tutores.First();
    //         Console.WriteLine("\n[OK] Mascotas de " + t.Nombre + ":");
    //         if (t.Mascotas.Count > 0)
    //         {
    //             foreach (var m in t.Mascotas)
    //             {
    //                 Console.WriteLine("• " + m.Nombre + " - " + m.Especie + "/" + m.Raza + ", " + m.Edad + " años");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("   (Este tutor no tiene mascotas registradas)");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine(" No se encontró ningún tutor con ese nombre o CC.");
    //     }
    //     Console.WriteLine("\nPresione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    //
    // private static void RegistrarTutor()
    // {
    //     Console.Write("\nNombre: ");
    //     string nombre = Console.ReadLine().Trim().ToLower();
    //
    //     Console.Write("CC: ");
    //     string cc = Console.ReadLine().Trim();
    //
    //     Console.Write("Teléfono: ");
    //     string telefono = Console.ReadLine().Trim();
    //
    //     Console.Write("Email: ");
    //     string email = Console.ReadLine().Trim();
    //
    //     var nuevoTutor = new Tutor(nombre, cc, telefono, email);
    //     _tutorService.Registrar(nuevoTutor);
    //     Console.WriteLine("\n[OK] Tutor registrado con éxito.");
    //     Console.WriteLine("Presione cualquier tecla para continuar...");
    //     Console.ReadKey();
    // }
    // #endregion
}