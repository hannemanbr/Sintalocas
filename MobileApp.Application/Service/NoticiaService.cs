using MobileApp.Application.Interfaces;
using MobileApp.Infra.Common.Repository;
using System.Collections.Generic;
using System.Linq;
using MobileApp.Application.Mapping;
using MobileApp.Infra.ObjectsDataTransfers.Classes;

namespace MobileApp.Application.Service
{
    public class NoticiaService : ApplicationServiceBase, INoticiaService
    {
        private readonly INoticiaRepository _noticiaRespository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRespository = noticiaRepository;
        }

        public IEnumerable<NoticiaDTO> GetAll()
        {
            return _noticiaRespository.GetAll().Select(x => x.ConvertToNoticiaDTO()).ToList();
        }

        public NoticiaDTO GetById(int id)
        {
            var dto = _noticiaRespository.GetById(id);

            return dto?.ConvertToNoticiaDTO() ?? null;
        }

    }
}
