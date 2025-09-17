using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Entities.Models;

/// <summary>
/// ENTIDAD DE NEGOCIO QUE REPRESENTA UN USUARIO EN EL SISTEMA.
/// DEFINE LAS PROPIEDADES BASICAS PARA PERSISTENCIA EN LA BD.
/// </summary>
public class Usuario
{
    /// <summary>
    /// Identificador unico del usuario (autoincremental)
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nombre del usuario. Maximimo 100 caracteres. Required
    /// </summary>
    [Required(ErrorMessage = "El nombre es requerido.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Apellido del Usuario. Maximo 100 caracteres. Required
    /// </summary>
    [Required(ErrorMessage = "El apellido es requerido.")]
    [StringLength(100, ErrorMessage = "El apellido no puede exceder 100 caracteres.")]
    public string Apellido { get; set; } = string.Empty;
}
