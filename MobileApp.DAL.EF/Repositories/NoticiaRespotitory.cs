using MobileApp.Domain.Classes;
using System.Linq;

namespace MobileApp.DAL.EF.Repositories
{
    public class NoticiaRespotitory : BaseRepository
    {
        public NoticiaRespotitory(ContextDB context) : base(context) { }

        public IQueryable<Noticia> GetAll()
        {
            return _contexto.Noticias.Where(x => x.DELETED == 0);
        }

    }
}
