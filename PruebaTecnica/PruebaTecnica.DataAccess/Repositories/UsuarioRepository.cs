using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PruebaTecnica.DataAccess.Contexts;
using PruebaTecnica.Entities.Models;
using System.Data.Common;

namespace PruebaTecnica.DataAccess.Repositories;

/// <summary>
/// REPOSITORIO PARA OPERACIONES CRUD EN LA ENTIDAD USUARIO.
/// IMPLEMNETA PATRON REPOSITORY PARA ABSTRACCION DE DATOS.
/// </summary>
public class UsuarioRepository
{
    private readonly PruebaSDContext _context;
    private readonly ILogger<UsuarioRepository> _logger;

    /// <summary>
    /// Ctor que inyecta el context de BD y Logger.
    /// </summary>
    /// <param name="context">Contexto de entity framework para acceso a datos.</param>
    /// <param name="logger">Instancia de logger para registrar los eventos y errores.</param>
    public UsuarioRepository(
        PruebaSDContext context, 
        ILogger<UsuarioRepository> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }


    /// <summary>
    /// Obtiene todos los usuarios de la BD de forma asincrona,
    /// </summary>
    /// <returns>Lista de usuarios. Es vacia si no hay datos.</returns>
    /// <exception cref="DbException">si ocurre un error en la conexion o consulta de BD</exception>
    public async Task<List<Usuario>> GetAllUsuariosAsync()
    {
        try
        {
            _logger.LogInformation("Iniciando consulta de todos los usuarios.");
            var usuarios = await _context.Usuarios.ToListAsync();
            _logger.LogInformation("Consulta completada. {Count} usuarios encontrados.", 
                usuarios.Count);

            return usuarios;
        }
        catch (DbException dbEx)
        {
            _logger.LogError(dbEx, "Error de base de datos al consultar usuarios.");
            throw;
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "Error inesperado al consultar usuarios.");
            throw;
        }
    }
}
