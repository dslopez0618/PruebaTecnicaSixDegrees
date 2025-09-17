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
1. Clonar el repositorio:
git clone https://github.com/tu-usuario/PruebaTecnicaSixDegrees.git

2. Abrir la solución en Visual Studio 2017/2019/2022 (`PruebaTecnica.sln`).
3. Configura la cadena de conexión ``appsettings.json` (PruebaTecnica.Services):
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=PruebaSD;Trusted_Connection=True;TrustServerCertificate=True;"
}
4. Restaure paquetes NuGet y ejecute el backenf (F5)
5. Navegue a `PruebaTecnica.Presentatio,`, ejecute `npm install`, y luego `ng serve` para el frontend.

## Uso
- Acceda al frontend en `http://localhost:4200`.
- Haga clic en "Buscar" para consultar los usuarios desde la API.

## Mejoras Visuales
- Diseño moderno con gradients, sombras y responsividad.
- Encabezado con ícono, mensaje de carga y pie de página.
- Tabla con filas alternadas y bordes redondeados.

## Fecha de Entrega
- 17 de Septiembre de 2025, 02:15 PM -05

## Autor
- Daniel López - dslopez0618

