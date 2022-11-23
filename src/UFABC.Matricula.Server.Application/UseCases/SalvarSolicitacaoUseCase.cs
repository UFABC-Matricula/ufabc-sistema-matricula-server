using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFABC.Matricula.Server.Application.UseCases.Input;

namespace UFABC.Matricula.Server.Application.UseCases
{
    public class SalvarSolicitacaoUseCase
    {
        public SalvarSolicitacaoUseCase()
        {

        }

        public Task<bool> SalvarSolicitacao(SalvarSolicitacaoUseCaseInput input)
        {
            return Task.FromResult(true);
            /*
             * Buscar aluno
             * Fazer update na lista de disciplinas
             * Salvar requisição
             * 
             * Incrementar +1 na turma 
             * Adicionar aluno no ranking 
             */
        }
    }
}
