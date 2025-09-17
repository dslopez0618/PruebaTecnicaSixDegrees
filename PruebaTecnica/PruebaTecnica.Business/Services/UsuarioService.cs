using Microsoft.Extensions.Logging;
using PruebaTecnica.DataAccess.Repositories;
using PruebaTecnica.Entities.Models;

namespace PruebaTecnica.Business.Services;

/// <summary>
/// SERVICIO DE NEGOCIO PARA LOGINA RELACIONADA CON USUARIOS.
/// ORQUESTA LLAMADAS AL REPOSITORIO DE ACCESO A DATOS.
/// </summary>
public class UsuarioService
{
    private readonly UsuarioRepository _repository;
    private readonly ILogger<UsuarioService> _logger;


    /// <summary>
    /// Ctor que inyecta el repositorio y el logger.
    /// </summary>
    /// <param name="repository">Repositorio para acceso a datos de usuario.</param>
    /// <param name="logger">Instancia de logger para registrar eventos.</param>
    public UsuarioService(
        UsuarioRepository repository, 
        ILogger<UsuarioService> logger)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }


    /// <summary>
    /// Obtiene lista completa de usuarios.
    /// </summary>
    /// <returns>Lista de usuarios.</returns>
    public async Task<List<Usuario>> GetAllUsuariosAsync()
    {
        try
        {
            _logger.LogInformation("Servicio de negocio: Solicitando todos los usuarios.");
            var  usuarios = await _repository.GetAllUsuariosAsync();


            if (usuarios == null || !usuarios.Any())
            {
                _logger.LogWarning("No se encontraron usuarios.");
            }

            return usuarios;

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error en logica de negocio al obtener usuarios.");
            throw;
        }
    }
}
