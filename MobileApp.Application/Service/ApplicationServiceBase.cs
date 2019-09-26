using MobileApp.Application.Messaging;

namespace MobileApp.Application.Service
{
    public abstract class ApplicationServiceBase
    {        

        protected void ConfigurarResponseComSucesso(BaseResponse response)
        {
            response.Success = true;
        }

        protected void ConfigurarResponseComSucesso(BaseResponse response, string message)
        {
            response.Success = true;
            response.Message = message;
        }

        protected void ConfigurarResponseComFalha(BaseResponse response, string message)
        {
            response.Success = false;
            response.Message = message;
        }

    }
}
