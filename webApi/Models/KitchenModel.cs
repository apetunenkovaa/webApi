using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class KitchenModel
    {
        public KitchenModel(Kitchen kitchen)
        {
            ID_Kitchen = kitchen.ID_Kitchen;
            Name_Kitchen = kitchen.Name_Kitchen;
        }
        public int ID_Kitchen { get; set; }
        public string Name_Kitchen { get; set; }
    }
}