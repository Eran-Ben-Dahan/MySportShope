﻿namespace MySportShope.API.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory>? SubCategorys { get; set; }
        public int PersoneTypeID { get; set; }
    }
}
