using System;
using System.Text;

namespace QuickTest
{
    public class Post
    {
        public string Title { get; }
        public string PostLink { get; }
        public string PhotoLink { get; }

        public Post(string title, string postLink, string photoLink)
        {
            Title = title;
            PostLink = postLink;
            PhotoLink = photoLink;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            builder.Append($"Title: \t {Title + Environment.NewLine}");
            builder.Append($"PostLink: \t {PostLink + Environment.NewLine}");
            builder.Append($"PhotoLink: \t {PhotoLink + Environment.NewLine}");
            
            return builder.ToString();
        }
    }
}