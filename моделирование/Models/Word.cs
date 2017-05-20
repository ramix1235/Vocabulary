using System.ComponentModel.DataAnnotations;

namespace моделирование.Models
{
    class Word
    {
        public int WordID { get; set; }
        [MaxLength(200)]
        public string RussianTranslation { get; set; }
        [MaxLength(200)]
        public string EnglishTranslation { get; set; }
        public int VocabularyID { get; set; }

        public virtual Vocabulary Vocabulary { get; set; }
    }
}
