using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Users
    {
        private int age;
        private string name;
        private int score;
        
        public int Age
        {
            get
            {return age;}
            set
            {age = value;}
        }

       
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public int Score
        { get { return score; }
            set { score = value; }
        }

        public override string ToString()
        {
            return $"User: {name} Age: {age} Score:{score}/10\n";
        }
    }
}
