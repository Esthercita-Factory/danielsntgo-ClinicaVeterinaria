using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.UI;
using ClinicaVeterinaria.Services;
using ClinicaVeterinaria.Repositories;

var almacen = new Almacen();

var citaRepository = new CitaRepository(almacen);
var mascotaRepository = new MascotaRepositories(almacen);
var tutorRepository = new TutorRepositories(almacen);

var citaService = new CitaServices(citaRepository);
var mascotaService = new MascotaServices(mascotaRepository);
var tutorService = new TutorService(tutorRepository);

ControlMenu.Iniciar();