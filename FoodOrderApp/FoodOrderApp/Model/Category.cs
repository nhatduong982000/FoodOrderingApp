﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrderApp.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPoster { get; set; }
        public string ImageUrl { get; set; }

        public static implicit operator Category(string v)
        {
            throw new NotImplementedException();
        }
    }
}
