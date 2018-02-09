using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace QuickTest
{
    public class RssReader
    {
        private const string RssPath = "https://feedity.com/fcbarcelona-com/WlZbWlpR.rss";
        
        private HttpClient _client = new HttpClient();
        private XmlDocument _xmlDocument = new XmlDocument();
        
        public async Task<List<Post>> ReadAsync()
        {
            var feed = await _client.GetStringAsync(RssPath);
            
            _xmlDocument.LoadXml(feed);

            var xElement = XElement.Parse(feed);
            var posts = ParsePosts(xElement);

            return posts;
        }
        
        private static List<Post> ParsePosts(XElement element)
        {
            var posts = element.Element("channel")
                ?.Elements("item")
                .Select(item => new Post(item.Element("title")?.Value, item.Element("link")?.Value,
                    item.Element("enclosure")?.Attribute("url")?.Value)).AsParallel();

            return posts?.ToList();
        }
    }
}