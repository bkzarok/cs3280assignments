using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public class Tree
    {
        public string sha { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return $"sha: {sha}\nurl: {url}";
        }
    }
}
