using System.Collections.Generic;
using UFABC.Matricula.Server.Api.Models.Enums;

namespace UFABC.Matricula.Server.Api.Models
{
    public class TurmaModel
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string NomeDisciplina { get; set; }
        public string NomeTurma { get; set; }
        public CampusEnum Campus { get; set; }
        public TurnoEnum Turno { get; set; }
        public int CreditosT { get; set; }
        public int CreditosP { get; set; }
        public int CreditosI { get; set; }
        public string NomeDocenteTeoria { get; set; }
        public string NomeDocentePratica { get; set; }
        public List<HorarioModel> Horarios { get; set; }
    }
}
