using System.ComponentModel.DataAnnotations;

namespace моделирование.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
    }
}
