using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc_MongoDB.Models
{
    public class DisciplinaDataModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id {get; set;}

        [Required]
        [Display(Name = "Sigla")]
        private string Sigla {get; set;}

        [Required]
        [Display(Name = "Nome")]
        private string Nome {get; set;}

        [Required]
        [Display(Name = "T")]
        private int Teoria {get; set;}

        [Required]
        [Display(Name = "P")]
        private int Pratica {get; set;}

        [Required]
        [Display(Name = "I")]
        private int EstudoIndividual {get; set;}

        [Required]
        [Display(Name = "Recomendação")]
        private string[] Recomendacao {get; set;}

        /*[Required]
        [Display(Name = "Cursos")]
        private string[] Cursos {get; set;}

        /*[Required]
        [Display(Name = "Cursos Obrigatórios")]
        private string[] CursosObrigatorios {get; set;}

        [Required]
        [Display(Name = "Cursos Opção Limitada")]
        private string[] CursosOpcaoLimitada {get; set;}

        /*[Required]
        [Display(Name = "Objetivos")]
        private string Objetivos {get; set;}

        [Required]
        [Display(Name = "Ementa")]
        private string Ementa {get; set;}

        /*[Required]
        [Display(Name = "Bibliografia Básica")]
        private string BibliografiaBasica {get; set;}

        [Required]
        [Display(Name = "Bibliografia Complementar")]
        private string BibliografiaComplementar {get; set;}*/
    }
}