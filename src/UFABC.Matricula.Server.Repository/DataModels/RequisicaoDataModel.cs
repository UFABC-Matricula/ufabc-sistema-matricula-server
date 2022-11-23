using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc_MongoDB.Models
{
    public class Disciplina
    {
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id {get; set;}

        //DataHora

        [Required]
        [Display(Name = "Código")]
        private string Codigo {get; set;}

        [Required]
        [Display(Name = "RA")]
        private string RA {get; set;}
    }
}