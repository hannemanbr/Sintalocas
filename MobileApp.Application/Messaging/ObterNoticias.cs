using MobileApp.Infra.ObjectsDataTransfers.Classes;
using System.Collections.Generic;

namespace MobileApp.Application.Messaging
{
    public class ObterNoticiasRequest
    {
    }

    public class ObterNoticiasResponse : BaseResponse
    {
        public IEnumerable<NoticiaDTO> Noticia;
    }
}
