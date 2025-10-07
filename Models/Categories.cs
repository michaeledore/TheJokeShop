using System.ComponentModel.DataAnnotations;

namespace TheJokeShop.Models
{
    public class Categories
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(5)]
        public string? Name { get; set; }

        public ICollection<Joke> Jokes { get; set; } = new List<Joke>();

    }
}
