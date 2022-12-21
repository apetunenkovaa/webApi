using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class FreetimeModel
    {

        public FreetimeModel(Freetime freetime)
        {
            ID_Freetime = freetime.ID_Freetime;
            Data_met = freetime.Data_met;
            Month = freetime.Month;
           
        }
        public int ID_Freetime { get; set; }
        public DateTime Data_met { get; set; }
        public string Month { get; set; }

    }
}