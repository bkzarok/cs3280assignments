using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{

    public class Commit
    {
        public Author author { get; set; }
        public Committer committer { get; set; }
        public string message { get; set; }
        public Tree tree { get; set; }
        public string url { get; set; }
        public int comment_count { get; set; }
        public Verification verification { get; set; }


              public override string ToString()
              {
                  return $"{author}\n{committer}\nmessage: {message}\n{tree}\nurl: {url}" +
                      $"\ncomment_count {comment_count}\n{verification}";
              }
        }

}
