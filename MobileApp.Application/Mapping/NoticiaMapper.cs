using MobileApp.Domain.Classes;
using MobileApp.Infra.ObjectsDataTransfers.Classes;

namespace MobileApp.Application.Mapping
{
    public static class NoticiaMapper
    {
        public static NoticiaDTO ConvertToNoticiaDTO(this Noticia noticia)
        {
            return new NoticiaDTO()
            {
                Id = noticia.Id,
                Titulo = noticia.Titulo
            };
        }
    }
}