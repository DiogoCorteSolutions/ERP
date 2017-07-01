using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalSOS.Presentation.Models
{
    public class TipoOperacao_Models : BaseModels
    {
        public int IdTipoOperacao { get; set; }
        public string Cc { get; set; }
        public string Tipo { get; set; }
        public string Tipo2 { get; set; }
        public bool Status { get; set; }
        public string Operacao { get; set; }
       
    }
}