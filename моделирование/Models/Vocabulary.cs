using System.Collections.Generic;

namespace моделирование.Models
{
    class Vocabulary
    {
        public int VocabularyID { get; set; }
        public int countOfWord { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}
