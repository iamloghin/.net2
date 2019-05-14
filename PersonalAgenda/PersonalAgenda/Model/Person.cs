﻿namespace PersonalAgenda.Model
{
    using System;

    [Serializable]
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Others { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}