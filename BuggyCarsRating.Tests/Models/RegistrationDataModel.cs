﻿using System;

namespace BuggyCarsRating.Tests.Models
{
    public class RegistrationDataModel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public void RandomizeUsername() => Username = Guid.NewGuid().ToString();
    }
}
