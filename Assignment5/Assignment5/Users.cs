using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Users
    {
        public int age;
        public string name;
        
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

        public Users(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
