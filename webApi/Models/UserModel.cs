using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class UserModel
    {
        public UserModel(User user)
        {
            ID_User = user.ID_User;
            Name_User = user.Name_User;
            Firstname_User = user.Firstname_User;
            Login = user.Login;
            Password = user.Password;
            Age = user.Age;
            ID_Gender = user.ID_Gender;
            ID_Freetime = user.ID_Freetime;
            Adout_user = user.Adout_user;
            ID_fav_place = user.ID_fav_place;
            ID_fav_kitchen = user.ID_fav_kitchen;
            Photo_user = user.Photo_user;
        }
        public int ID_User { get; set; }
        public string Name_User { get; set; }
        public string Firstname_User { get; set; }
        public string Login  { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int ID_Gender { get; set; }
        public int ID_Freetime { get; set; }
        public string Adout_user { get; set; }
        public int ID_fav_place { get; set; }
        public int ID_fav_kitchen { get; set; }
        public string Photo_user { get; set; }





    }
}