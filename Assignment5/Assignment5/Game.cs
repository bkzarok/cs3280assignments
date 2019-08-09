using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
   public class Game
    {
        private char operation;
        private int firstnum;
        private int secondnum;
        private int answer;

        public char Operation {
   
            get { return operation; }
            set { operation = value; }
        }

        public int firstNum
        {
            get { return firstnum; }
            set { firstnum = value; }
        }

        public int secondNum
        {
            get { return secondnum; }
            set { secondnum = value; }
        }

        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public Game(char operation, int firstnum, int secondnum, int answer)
        {
            Operation = operation;
            firstNum = firstnum;
            secondNum = secondnum;
            Answer = answer;
        }
    }
}
