﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Records
{
    public record Subjects
    {
        private string _name;

        public string Name
        {
            get => _name; set => _name = value;
        }
    }
}
