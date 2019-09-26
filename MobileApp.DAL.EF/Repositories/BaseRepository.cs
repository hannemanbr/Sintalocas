using System.Linq;

namespace MobileApp.DAL.EF.Repositories
{
    public abstract class BaseRepository
    {
        public readonly ContextDB _contexto;

        protected BaseRepository(ContextDB contexto)
        {
            _contexto = contexto;
        }

        protected void Save()
        {
            _contexto.SaveChanges();
        }

    }
}
