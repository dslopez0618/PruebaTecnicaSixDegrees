using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Entities.Models;

namespace PruebaTecnica.DataAccess.Contexts;


/// <summary>
/// CONTEXTO DE BD PARA EL APP. PruebaSD
/// CONFIGURA EL MODELO DE ENTIDADES Y LA CONEXION A SQLServer.
/// </summary>
public class PruebaSDContext : DbContext
{
    /// <summary>
    /// Constructor que recive las opciones de conf. del DbContext
    /// </summary>
    /// <param name="options">Opciones de configuracion para entityframework</param>
    public PruebaSDContext(DbContextOptions<PruebaSDContext> options) : base(options)
    {
    }

    /// <summary>
    /// Conjunto de entidades Usuario.
    /// </summary>
    public DbSet<Usuario> Usuarios { get; set; }


    /// <summary>
    /// Sobrescribe la configuracion del modelo para mapear entidades a tables.
    /// </summary>
    /// <param name="modelBuilder">Ctor del modelo de Entity framework.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
            entity.Property(e => e.Apellido).HasMaxLength(100).IsRequired();
        });
        
        base.OnModelCreating(modelBuilder);
    }
}
