using Microsoft.EntityFrameworkCore;
using MobileApp.DAL.EF.Mapping;
using MobileApp.Domain.Classes;

namespace MobileApp.DAL.EF
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
        }

        public DbSet<Noticia> Noticias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoticiaMap());
        }
    }
}
