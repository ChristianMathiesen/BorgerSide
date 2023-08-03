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
        public string Forurening { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public OlietankFormular()
        {

        }
    }
}
