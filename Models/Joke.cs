using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheJokeShop.Models
{
    [Table("JokeList")]
    public class Joke
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength (50, MinimumLength = 3)]
        [Display(Name ="Title")]
        public string? Title { get; set; }

        [Required]
        [StringLength(350)]
        [Display(Name ="Joke Test")]
        public string? JokeTest { get; set; }

        [Required]
        [StringLength(325, MinimumLength = 3)]
        public string? Teaser { get; set; }

        [Required, DataType(DataType.Date)]
        [Display(Name = "Creation Date")]
        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }


        [Required]
        public int CategoryId { get; set; }
        public Categories? Category { get; set; }

    }
}
