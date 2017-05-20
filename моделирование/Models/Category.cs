using System.ComponentModel.DataAnnotations;

namespace моделирование.Models
{
    class Category
    {
        public int CategoryID { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        //[NotMapped]
        //public int Statistics_StatisticID { get; set; }

        //public virtual Statistic Statistic { get; set; }
    }
}
