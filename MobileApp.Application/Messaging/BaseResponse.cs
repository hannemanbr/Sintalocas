using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Application.Messaging
{
    public class BaseResponse
    {
        public string Message { get; set; }
        public virtual bool Success { get; set; }

        public static string JuntaMensagens(params BaseResponse[] responses)
        {
            var lista = new List<string>();

            foreach (var r in responses)
            {
                if (!string.IsNullOrEmpty(r.Message))
                    lista.Add(r.Message);
            }

            return string.Join("\n", lista);
        }
    }
}
