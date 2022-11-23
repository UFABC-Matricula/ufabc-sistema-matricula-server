using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc_MongoDB.Models
{

    private enum CampusEnum
    {
        Santo André,
        São Bernardo do Campo,
        MAX_CAMPI
    }

    private enum TurnoEnum
    {
        Matutino,
        Noturno,
        MAX_TURNOS
    }

    struct CursoDeGraduacao
    {
        string Curso;
        CampusEnum Campus;
        TurnoEnum Turno;
        double CP;
    }

    public class AlunoDataModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id {get; set;}

        [Required]
        [Display(Name = "RA")]
        private string RA {get; set;}

        [Required]
        [Display(Name = "Nome")]
        private string Nome {get; set;}

        [Required]
        [Display(Name = "Login")]
        private string Login {get; set;}

        [Required]
        [Display(Name = "Senha")]
        private string Senha {get; set;}

        [Required]
        [Display(Name = "Cursos de Graduação")]
        private CursoDeGraduacao CursosDeGraduacao {get; set;}
    }
}