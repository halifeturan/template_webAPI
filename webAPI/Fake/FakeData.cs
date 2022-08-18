﻿using Bogus;
using System.Collections.Generic;
using webAPI.Model;

namespace webAPI.Fake
{
    public static class FakeData
    {
        private static List<User> _users;
        public static List<User> GetUsers(int number)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
         .RuleFor(u => u.Id, f => f.IndexFaker + 1)
         .RuleFor(u => u.Name, f => f.Name.FirstName())
         .RuleFor(u => u.LastName, f => f.Name.LastName())
         .RuleFor(u => u.Adress, f => f.Address.FullAddress()).Generate(number);
            }
            return _users;
        }
    }
}
