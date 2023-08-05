using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BorgerSide.Models
{



    public class OlietankFormular
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Ejer { get; set; }
        [Required]
        public string Navn { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public int Telefonnummer { get; set; }
        [Required]
        public int Registreringsnummer { get; set; }
        public int Typegodkendelsesnummer { get; set; }
        public int Fabrikationsår { get; set; }
        public int Størrelse { get; set; }
        
        //public IFormFile Prægeplade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Sløjfningsdato { get; set; }
        [Required]
        public string Sløjfningsmetode { get; set; }
        [Required]
        public string Forurening { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public OlietankFormular()
        {

        }
    }
}
