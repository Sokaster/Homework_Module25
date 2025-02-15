﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Enums;

namespace Homework_Module25
{
    internal class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Sex Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> JobPreferences { get; set; }

        public List<string> LocationPreferences { get; set; }

        public string Profession { get; set; }

        public int Age()
        {
            DateTime date = DateTime.UtcNow;
            int age = ((date.Year * 12 + date.Month) - (BirthDate.Year * 12 + BirthDate.Month)) / 12;
            return age;
        }
    }
}
