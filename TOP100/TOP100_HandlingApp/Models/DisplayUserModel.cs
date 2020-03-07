using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOP100_HandlingApp.Data
{
    public class DisplayUserModel
    {
        public DisplayUserModel()
        {
            Name = string.Empty;
            Password = string.Empty;
            Mail = string.Empty;
        }
        public DisplayUserModel(int id, string name, string password, string mail)
        {
            Id = id;
            Name = name;
            Password = password;
            Mail = mail;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }


    }
}
