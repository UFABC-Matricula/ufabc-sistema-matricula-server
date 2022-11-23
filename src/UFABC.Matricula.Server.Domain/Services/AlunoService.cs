using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFABC.Matricula.Server.Domain.Enums;

namespace UFABC.Matricula.Server.Domain.Services
{
    public class AlunoService
    {
         public string Nome { get; set; }
        public string RA { get; set; }
        public TurnoEnum Turno { get; set; }
        public CursosEnum Curso { get; set; }
    }
}
