using MobileApp.Infra.ObjectsDataTransfers.Classes;

namespace MobileApp.Application.Messaging
{
    public class ObterNoticiaPorIDRequest
    {
        public int Id { get; set; }
    }

    public class ObterNoticiaPorIDResponse: BaseResponse
    {
        public NoticiaDTO Noticia;
    }
}
