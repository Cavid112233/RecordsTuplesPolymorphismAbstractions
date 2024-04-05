using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        private static int _id;
        public int Id { get; set; }
        private string _content { get; set; }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public Comment()
        {

        }
        public Comment(string content)
        {
            _id++;
            Id = _id;
            Content = content;
        }
        public override string ToString()
        {
            return $"Id:{Id}" + $"Content:{Content}";
        }
    }
}
