using System.ComponentModel.DataAnnotations;

namespace BorgerSide.Models
{
    public class OlietankFormular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Navn { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Ejer { get; set; }
        [Required]
        public string Ansoegning { get; set; }
        [Required]
        public int Registreringsnummer { get; set; }
        public int Typegodkendelsesnummer { get; set; }
        public int Fabrikationsår { get; set; }
        public int Stoerrelse { get; set; }
        [Required]
        public DateTime Sloejfningsdato { get; set; }
        [Required]
        public string Sloejfningsmetode { get; set; }
        [Required]
        public string Forurening { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public OlietankFormular()
        {

        }
    }
}
