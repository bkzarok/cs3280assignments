﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return $"name: {name}\nemail: {email}\n{date.ToString()}";
        }
    }
}
