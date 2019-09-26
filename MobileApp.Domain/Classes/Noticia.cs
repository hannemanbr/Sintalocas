using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApp.Domain.Classes
{
    public class Noticia : BaseDomain
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
    }
}
