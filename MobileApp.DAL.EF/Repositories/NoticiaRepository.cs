using System.Collections.Generic;
using System.Linq;
using MobileApp.Domain.Classes;
using MobileApp.Infra.Common.Repository;

namespace MobileApp.DAL.EF.Repositories
{
    public class NoticiaRepository : BaseRepository, INoticiaRepository
    {
        public NoticiaRepository(ContextDB context) : base(context)
        { }

        public void Add(Noticia entity)
        {
            _contexto.Add(entity);
            Save();
        }

        public IEnumerable<Noticia> GetAll()
        {
            return _contexto.Noticias;
        }

        public Noticia GetById(int id)
        {
            return _contexto.Noticias.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Noticia entity)
        {
            entity.DELETED = 1;
            Save();
        }

        public void Update(Noticia entity)
        {
            Save();
        }

    }
}
