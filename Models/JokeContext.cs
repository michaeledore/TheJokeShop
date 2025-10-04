using Microsoft.EntityFrameworkCore;

namespace TheJokeShop.Models
{
    public class JokeContext : DbContext
    {
        public DbSet<Joke> Jokes { get; set; }

        public JokeContext(DbContextOptions<JokeContext> options) :base(options)
        {
            
        }
    }
}
