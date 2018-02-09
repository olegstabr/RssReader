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
    }
}