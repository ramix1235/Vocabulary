using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace моделирование.Models
{
    public class Vocabulary
    {
        public int VocabularyID { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public int CountOfWord { get; set; }
        public int CategoryID { get; set; }
        public int LimitationForVocabularyID { get; set; }
        //[NotMapped]
        //public int Statistics_StatisticID { get; set; }

        //public virtual Statistic Statistic { get; set; }
        public virtual LimitationForVocabulary LimitationForVocabulary { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}
