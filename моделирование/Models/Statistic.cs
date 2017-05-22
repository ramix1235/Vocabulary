using System.Collections.Generic;

namespace моделирование.Models
{
    public class Statistic
    {
        public int StatisticID { get; set; }
        public int ScoreID { get; set; }
        public int EducationID { get; set; }
        //[NotMapped]
        //public int Education_EducationID { get; set; }
        //[NotMapped]
        //public int Score_ScoreID { get; set; }

        public virtual Score Score { get; set; }
        public virtual Education Education { get; set; }

        public virtual ICollection<Vocabulary> Vocabularies { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
