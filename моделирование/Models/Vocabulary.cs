using System.Collections.Generic;

namespace моделирование.Models
{
    class Vocabulary
    {
        public int VocabularyID { get; set; }
        public int CountOfWord { get; set; }
        public int CategoryID { get; set; }


        public virtual Category Category { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}
