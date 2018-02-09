using System;
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
        
        public RssReader()
        {
            
        }

        public async Task Read()
        {
            var feed = await _client.GetStringAsync(RssPath);
            
            _xmlDocument.LoadXml(feed);

            var xElement = XElement.Parse(feed).Descendants("item");
            Parallel.ForEach(xElement, ParsePost);
        }

        private void ParsePost(XElement item)
        {
//            Console.WriteLine(item);
            var name = item.Name.LocalName;
        }
    }
}