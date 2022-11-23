using System;
using System.Collections.Generic;

namespace UFABC.Matricula.Server.Application.UseCases.Input
{
    public class SalvarSolicitacaoUseCaseInput
    {
        public string RA { get; set; }
        public List<string> TurmasSelecionadas { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }
}
