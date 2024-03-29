﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Repository
{
    public interface IUserRepository
    {
        bool AddNewUser(User model);
        List<User> GetAllUsers();
        bool UserLogin(string email, string password);
    }
}
