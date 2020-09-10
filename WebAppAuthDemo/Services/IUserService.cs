﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAuthDemo.Services
{
    public interface IUserService
    {
        Task<bool> ValidateCredentials(string userbane, string password, out User user);
    }

    public class User
    {
        public string Username { get; }
        public User(string username)
        {
            Username = username;
        }
    }
}
