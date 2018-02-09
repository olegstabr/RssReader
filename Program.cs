using System;
using System.Threading.Tasks;

namespace QuickTest
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            var bot = new Bot();
            await bot.GetTokenFromFileAsync("/home/linuxoid/Desktop/token");
            
//            var rssReader = new RssReader();
//            await rssReader.Read();
            await bot.Start();
            Console.ReadLine();
            bot.Stop();
        }
    }
}
