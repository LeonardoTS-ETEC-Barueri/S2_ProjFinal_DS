using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOL_ProjFinalDS
{
    public class DTO_Compromisso
    {
        public int codCompromisso { get; set; }
        public string assunto { get; set; }
        public string dataCompromisso { get; set; }
        public string horario { get; set; }
        public string descricao { get; set; }
        public bool estaAtivo { get; set; }
        public List<DTO_Convidado> Convidados { get; set; } // Servirá como DataTable do dataGrindView - Listnado os convidados relacionados ao Compromisso.

    }
}
