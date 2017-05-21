using System.Data.Entity;
using моделирование.Models;

namespace моделирование.DataAccess
{
    public class VocabularyContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Limitation> Limitation { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Statistic> Statistic { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
