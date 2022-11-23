using UFABC.Matricula.Server.Api.Models.Enums;

namespace UFABC.Matricula.Server.Api.Models
{
    public class HorarioModel
    {
        public DiaSemanaEnum DiaAula { get; set; }
        public TipoAulaEnum TipoAula { get; set; }
        public PeriodicidadeAulaEnum PeriodicidadeAula { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFim { get; set; }
    }
}