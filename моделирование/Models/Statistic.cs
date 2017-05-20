using System.Collections.Generic;

namespace моделирование.Models
{
    class Statistic
    {
        public int StatisticID { get; set; }

        public virtual Score Score { get; set; }

        public virtual ICollection<Vocabulary> Vocabularies { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Education> Educations { get; set; }

    }
}
