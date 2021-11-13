﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReginaNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }

        public string Image { get; set; }
        public string Topic  { get; set; }
        

        public int CategoryId  { get; set; }
        public Category Category { get; set; }

        
    }
}
