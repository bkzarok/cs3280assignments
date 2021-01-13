using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public class RootObject1
    {
        public string sha { get; set; }
        public string node_id { get; set; }
        public Commit commit { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string comments_url { get; set; }
        public Author2 author { get; set; }
        public Committer2 committer { get; set; }
        public List<object> parents { get; set; }


        public override string ToString()
        {
            return $"sha: {sha}\n node_id: {node_id}\n {commit.ToString()}\nurl: {url}" +
                $"\nhtml_url: {html_url}\n comments_url: {comments_url}";
        }
    }
      


}
