namespace моделирование.Models
{
    public class Limitation
    {
        public int LimitationID { get; set; }
        public int MaxCountOfCategory { get; set; }
        public int MaxCountOfVocabulary { get; set; }
        public int DefaultMaxCountOfWordsInVocabulary { get; set; }
    }
}
