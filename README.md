# Prueba Técnica Six Dregrees - Daniel López

## Descripción
Esta es una solución multicapa para la prueba técnica, que incluye:
- **Capa de Presentación**: Frontend en Angular 17 con un diseño mejorado.
- **Capa de Servicios**: API REST en .NET 8.
- **Capa de Negocio**: Lógica de negocio en .NET.
- **Capa de Acceso a Datos**: Repositorios y contexto de Entity Framework.
- **Capa de Entidades**: Modelos de datos.

## Requisitos
- **Backend**: .NET 8 SDK, SQL Server (LocalDB o similar).
- **Frontend**: Node.js 20.x, Angular CLI 17.x.

## Instalación
1. **Clonar el repositorio**:
  `git clone https://github.com/tu-usuario/PruebaTecnicaSixDegrees.git`

2. **Configurar la base de datos**:
- Asegúrese de tener SQL Server instalado (se recomienda LocalDB para desarrollo).
- Crear una base de datos llamada `PruebaSD`:
```sql
  CREATE DATABASE PruebaSD;

- Use el siguiente script para crear la tabla `Usuario` y probarla con 5 registros;

``` 
USE PruebaSD;

CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL
);

INSERT INTO Usuario (nombre, apellido) VALUES
('Andres', 'Rodriguez Vera'),
('Maria', 'Lopez Gomez'),
('Juan', 'Perez Martinez'),
('Ana', 'Garcia Torres'),
('Pedro', 'Sanchez Ruiz');``` 

- Actualizar la cadena de conexión en `appsettings.json` (En `PruebaTecnica.Services`):
```
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=PruebaSD;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning",
      "PruebaTecnica": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
- Si usas otro servidor SQL (no LocalDB), ajusta la cadena de conexión con el nombre del servidor y credenciales adecuadas.

3. **Configurar el Backend**:
- Abra la solución en Visual Studio 2017/2019/2022 (`PruebaTecnica.sln`).
- Restaure los paquetes NuGet (Clic derecho en la solución > Restore Packages).
- Ejecuta el proyecto `PruebaTecnica.Services` (F5) para iniciar la API.
4. **Configurar el Frontend**:
- Navegue a `PrueaTecnica.Presentation`, ejecute `npm install` en la terminal.
- Ejecute `ng serve` para iniciar el frontend.

## Uso
- Acceda al frontend en `http://localhost:4200`.
- Haga clic en "Buscar" para consultar los usuarios desde la API.

## Mejoras Visuales
- Diseño moderno con gradients, sombras y responsividad.
- Encabezado con ícono, mensaje de carga y pie de página.
- Tabla con filas alternadas y bordes redondeados.

## Fecha de Entrega
- 17 de Septiembre de 2025, 02:30 PM -05

## Autor
- Daniel López - dslopez0618

