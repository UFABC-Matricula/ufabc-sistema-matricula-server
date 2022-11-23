using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFABC.Matricula.Server.Api.Models.Payloads
{
    public class SalvarSolicitacaoPayload
    {
        public string RA { get; set; }
        public List<string> IdsTurmasSelecionadas { get; set; }
    }
}
