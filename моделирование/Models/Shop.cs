﻿using System.Collections.Generic;

namespace моделирование.Models
{
    public class Shop
    {
        public int ShopID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
