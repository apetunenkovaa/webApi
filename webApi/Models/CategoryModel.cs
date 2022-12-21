using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class CategoryModel
    {


        public CategoryModel(Category category)
        {
            ID_Category = category.ID_Category;
            Name_category = category.Name_category;
            

        }
        public int ID_Category { get; set; }
        public string Name_category { get; set; }

    }
}