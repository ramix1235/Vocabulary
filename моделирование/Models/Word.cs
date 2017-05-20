namespace моделирование.Models
{
    class Word
    {
        public int WordID { get; set; }
        public string RussianTranslation { get; set; }
        public string EnglishTranslation { get; set; }

        public virtual Vocabulary Vocabulary { get; set; }
    }
}
