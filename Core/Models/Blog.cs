using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; set; }
        private string _title;
        private string _description;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(value.Length > 5)
                {
                    _title = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if(value.Length > 8)
                {
                    _description = value;
                }
            }
        }
        Comment[] Comments = { };
        public Blog()
        {

        }
        public Blog(string title, string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id:{Id} Title:{Title} Description:{Description}";
        }
        public Comment GetComment(int commentId)
        {
            foreach (var comment in Comments)
            {
                if (comment.Id == commentId)
                    return comment;
            }
            return null;
        }
        public Comment[] GetAllComments()
        {
            return Comments;
        }
        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;
        }
        public void RemoveComment(int commentId)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    Comments[i] = null;
                    break;
                }
            }
            Comments = Array.FindAll(Comments, c => c != null);
        }
        public void UpdateComment(int commentId, Comment comment)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    Comments[i] = comment;
                    break;
                }
            }
        }
    }
}
