﻿using System.Reflection.Metadata.Ecma335;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

    }
}