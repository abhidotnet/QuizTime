﻿using System;
using System.Linq;

namespace QuizTime.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerHandle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }

    }
}