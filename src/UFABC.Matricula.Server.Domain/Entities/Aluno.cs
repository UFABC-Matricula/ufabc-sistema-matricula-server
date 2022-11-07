using UFABC.Matricula.Server.Domain.Entities.Base;
using UFABC.Matricula.Server.Domain.Enums;

namespace UFABC.Matricula.Server.Domain
{
    public class Aluno
        : EntityBase
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public TurnoEnum Turno { get; set; }
        public CursosEnum Curso { get; set; }
    }
}
