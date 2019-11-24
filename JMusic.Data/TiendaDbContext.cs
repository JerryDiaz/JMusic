using System;
using JMusic.Data.Configuracion;
using JMusic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JMusic.Data
{
    public partial class TiendaDbContext : DbContext
    {
        public TiendaDbContext()
        {
        }

        public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetalleOrden> DetallesOrden { get; set; }
        public virtual DbSet<Orden> Ordenes { get; set; }
        public virtual DbSet<Perfil> Perfiles { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.ApplyConfiguration(new DetalleOrdenConfiguracion());

            modelBuilder.ApplyConfiguration(new OrdenConfiguracion());

            modelBuilder.ApplyConfiguration(new PerfilConfiguracion());

            modelBuilder.ApplyConfiguration(new ProductoConfiguracion());

            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
        }
    }
}
