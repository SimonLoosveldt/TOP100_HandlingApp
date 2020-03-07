using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly IDataProvider db;

        public UserData(IDataProvider db)
        {
            this.db = db;
        }

        public Task<List<UserModel>> GetUsers()
        {
            var users = new List<UserModel>
            {
                new UserModel()
                {
                    Mail = "michel.michels.jr@gmail.com",
                    Name = "Michel",
                    Password = "test",
                },
                new UserModel()
                {
                    Mail = "loosveldt.simon@gmail.com",
                    Name = "Simon",
                    Password = "test",
                }
            };

            return Task.FromResult(users);
        }
    }
}
