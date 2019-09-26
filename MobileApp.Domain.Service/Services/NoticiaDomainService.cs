using MobileApp.Domain.Classes;
using MobileApp.Infra.Common.Repository;
using System.Collections.Generic;

namespace MobileApp.Domain.Service.Services
{
    public class NoticiaDomainService : INoticiaRepository
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaDomainService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public void Add(Noticia entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Noticia> GetAll()
        {
            return _noticiaRepository.GetAll();
        }

        public Noticia GetById(int id)
        {
            return _noticiaRepository.GetById(id);
        }

        public void Remove(Noticia entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Noticia entity)
        {
            throw new System.NotImplementedException();
        }

    }
}
