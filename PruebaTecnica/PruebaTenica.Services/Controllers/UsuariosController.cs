using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Business.Services;

namespace PruebaTecnica.API.Controllers;


/// <summary>
/// Controlador para operaciones REST en usuarios (API)
/// Expone endpoints para consulta de datos
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly UsuarioService _usuarioService;

    /// <summary>
    /// Ctor que inyecta service de negocio.
    /// </summary>
    /// <param name="usuarioService">Servicio de logica para usuarios.</param>
    public UsuariosController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
    }


    /// <summary>
    /// Endpoint GET para obtener todos los usuarios.
    /// Retorna una lista con ID y nombre completo (nombre + apellido)
    /// </summary>
    /// <returns>Lista de usuario. Codigo 200 Ok si es exito, 500 si es error</returns>
    /// <response code="200">Lista de usuarios obtenida exitosamente.</response>
    /// <response code="500">Error interno del servidor.</response>
    [HttpGet]
    public async Task<IActionResult> GetUsuarios()
    {
        try
        {
            var usuarios = await _usuarioService.GetAllUsuariosAsync();
            var resultado = usuarios.Select(u => new
            {
                u.Id,
                Nombre = $"{u.Nombre} {u.Apellido}"
            }).ToList();

            return Ok(resultado);
        }
        catch (Exception ex)
        {
            // Se puede dejar un logger en produccion, aqui voy a dejar un colsole.writeline para simplicidad
            Console.WriteLine($"Error en Controller: {ex.Message}");
            return StatusCode(500, "Error interno al consultar usuarios");
        }
    }
}
