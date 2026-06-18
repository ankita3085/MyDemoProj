using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService
    {
        public string PopulateUser()
        {
            User userModel = new User();
            userModel.Name = "Ankita";
            userModel.Age = 26;
            userModel.Rehire = "123, ST Col";
            userModel.ZipCode = 123456;

            return JsonConvert.SerializeObject(userModel);
        }

        public string Ankita()
        {
            User userModel = new User();
            userModel.Name = "Ankita";
            userModel.Age = 26;
            userModel.Rehire = "12345";
            userModel.ZipCode = 123456;

            return JsonConvert.SerializeObject(userModel);
        }
    }
}
