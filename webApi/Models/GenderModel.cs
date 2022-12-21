using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class GenderModel
    {
        public GenderModel(Gender gender)
        {
            Id_Gender = gender.Id_Gender;
            Gender_name = gender.Gender_name;
        }
        public int Id_Gender { get; set; }
        public string Gender_name { get; set; }

    }
}