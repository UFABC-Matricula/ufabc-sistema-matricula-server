using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;
using UFABC.Matricula.Server.Api.Models;
using UFABC.Matricula.Server.Api.Models.Payloads;
using UFABC.Matricula.Server.Api.Models.Responses;
using UFABC.Matricula.Server.Application.UseCases;
using UFABC.Matricula.Server.Application.UseCases.Input;

namespace UFABC.Matricula.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaMatriculaController : ControllerBase
    {
        [HttpGet("/get-resumo")]
        [ProducesResponseType(typeof(GetResumoResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetResumo(
            [FromQuery] string ra)
        {
            var response = new GetResumoResponse
            {
                HoraSolicitacao = DateTime.Now,
                TokenAutenticacao = Guid.NewGuid().ToString(),
                RA = ra,
                NomeAluno = "Aluno Teste",
                CampusAluno = Models.Enums.CampusEnum.SantoAndre,
                TurnoAluno = Models.Enums.TurnoEnum.Noturno,
                CreditosTP = 16,
                CreditosTPI = 40,
                Turmas = new System.Collections.Generic.List<TurmaModel>()
            };

            for (int i = 1; i < 4; i++)
            {
                var turma = new TurmaModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Codigo = $"ABCD-{i}",
                    NomeDisciplina = $"Disciplina {i}",
                    NomeTurma = $"A{i}",
                    Campus = Models.Enums.CampusEnum.SantoAndre,
                    Turno = Models.Enums.TurnoEnum.Noturno,
                    CreditosT = i,
                    CreditosP = 4-i,
                    CreditosI = i*2,
                    NomeDocenteTeoria = $"Docente Teoria {i}",
                    NomeDocentePratica = $"Docente Pratica {i}",
                    Horarios = new System.Collections.Generic.List<HorarioModel>()
                };

                var horario1 = new HorarioModel {
                    TipoAula = Models.Enums.TipoAulaEnum.Pratica,
                    PeriodicidadeAula = Models.Enums.PeriodicidadeAulaEnum.Semanal,
                    HoraInicio = 19,
                    HoraFim = 21
                };

                var horario2 = new HorarioModel
                {
                    TipoAula = Models.Enums.TipoAulaEnum.Teoria,
                    PeriodicidadeAula = Models.Enums.PeriodicidadeAulaEnum.Semanal,
                    HoraInicio = 21,
                    HoraFim = 23
                };

                switch (i)
                {
                    case 1:
                        horario1.DiaAula = Models.Enums.DiaSemanaEnum.SegundaFeira;
                        horario2.DiaAula = Models.Enums.DiaSemanaEnum.QuartaFeira;
                        break;
                    case 2:
                        horario1.DiaAula = Models.Enums.DiaSemanaEnum.QuartaFeira;
                        horario2.DiaAula = Models.Enums.DiaSemanaEnum.SegundaFeira;
                        break;
                    case 3:
                        horario1.DiaAula = Models.Enums.DiaSemanaEnum.QuintaFeira;
                        horario2.DiaAula = Models.Enums.DiaSemanaEnum.TercaFeira;
                        break;
                    case 4:
                        horario1.DiaAula = Models.Enums.DiaSemanaEnum.TercaFeira;
                        horario2.DiaAula = Models.Enums.DiaSemanaEnum.QuintaFeira;
                        break;
                }

                turma.Horarios.Add(horario1);
                turma.Horarios.Add(horario2);

                response.Turmas.Add(turma);
            }

            var actionResult = default(IActionResult);
            actionResult = new OkObjectResult(response);

            return actionResult;
        }

        [HttpPost("/salvar-solicitacao")]
        public async Task<IActionResult> SalvarSolicitacao(
            [FromBody] SalvarSolicitacaoPayload payload)
        {
            var useCaseInput = new SalvarSolicitacaoUseCaseInput{
                DataSolicitacao = System.DateTime.Now,
                RA = payload.RA, 
                TurmasSelecionadas = payload.IdsTurmasSelecionadas
            };

            var useCase = new SalvarSolicitacaoUseCase();

            var useCaseResult = await useCase.SalvarSolicitacao(useCaseInput);

            var actionResult = default(IActionResult);
            actionResult = new OkObjectResult(useCaseResult);

            return actionResult;
        }
    }
}
