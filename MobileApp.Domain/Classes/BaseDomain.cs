using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Domain.Classes
{
    public class BaseDomain
    {
        public int Id { get; set; }
        public int DELETED { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
