using System.ComponentModel.DataAnnotations;

namespace BorgerSide.Models
{
    public class BorgerTip
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Navn { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public BorgerTip()
        {

        }
    }


}
