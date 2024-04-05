using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool CheckBlogTitle(string title)
        {
            return title.Length > 5;
        }

        public static bool CheckBlogDescription(string description)
        {
            return description.Length > 8;
        }
    }
}
