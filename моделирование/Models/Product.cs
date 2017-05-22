using System;
using System.ComponentModel.DataAnnotations;

namespace моделирование.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}
