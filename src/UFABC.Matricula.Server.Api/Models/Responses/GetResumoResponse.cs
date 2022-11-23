using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UFABC.Matricula.Server.Api.Models.Enums;

namespace UFABC.Matricula.Server.Api.Models.Responses
{
    public class GetResumoResponse
    {
        public DateTime HoraSolicitacao { get; set; }
        public string TokenAutenticacao { get; set; }

        /*Aluno*/
        public string RA { get; set; }
        public string NomeAluno { get; set; }
        public CampusEnum CampusAluno { get; set; }
        public TurnoEnum TurnoAluno { get; set; }

        /*Carga Semanal*/
        public int CreditosTP { get; set; }
        public int CreditosTPI { get; set; }

        /*Turmas*/
        public List<TurmaModel> Turmas { get; set; }
    }
}
