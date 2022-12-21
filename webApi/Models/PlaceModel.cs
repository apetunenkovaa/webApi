using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class PlaceModel
    {
        public PlaceModel(Place place)
        {
            ID_Place = place.ID_Place;
            Name_Place = place.Name_Place;
            ID_Category = place.ID_Category;
            ID_Kitchen = place.ID_Kitchen;
            AverageCheck = (int)place.AverageCheck;
            Stars = place.Stars;

        }
        public int ID_Place { get; set; }
        public string Name_Place { get; set; }
        public int ID_Category { get; set; }
        public int ID_Kitchen { get; set; }
        public int AverageCheck { get; set; }
        public int Stars { get; set; }


    }
}