# danielsntgo-ClinicaVeterinaria

Sistema de gestión para una clínica veterinaria, desarrollado como aplicación de consola en **C# 14** sobre **.NET 10**. El proyecto está diseñado siguiendo una **arquitectura en capas**, separando responsabilidades entre presentación, lógica de negocio y acceso a datos, con el objetivo de mantener un código organizado, mantenible y escalable.

##  Características

- Gestión de pacientes (mascotas) y sus dueños
- Registro de consultas / historial clínico
- Persistencia de datos en memoria (sin base de datos externa)
- Aplicación 100% de consola (CLI)

## Tecnologías

- **Lenguaje:** C# 14
- **Framework:** .NET 10
- **Contenedores:** Docker
- **Persistencia:** En memoria (local)

## Arquitectura

El proyecto sigue una **arquitectura en capas (Layered Architecture)**:

- **Capa de Presentación:** interacción con el usuario por consola
- **Capa de Aplicación / Negocio:** reglas y lógica del dominio veterinario
- **Capa de Datos:** repositorios en memoria que simulan la persistencia

## Docker

El proyecto incluye soporte para ejecutarse en un contenedor Docker, facilitando su despliegue y ejecución sin depender del entorno local.

## Cómo ejecutar

\`\`\`bash
# Clonar el repositorio
cd ClinicaVeterinaria

# Entrar al directorio
cd ClinicaVeterinaria

# Ejecutar con .NET
dotnet run

# O construir y ejecutar con Docker
docker build -t ClinicaVeterinaria
docker run -it  ClinicaVeterinaria
\`\`\`
