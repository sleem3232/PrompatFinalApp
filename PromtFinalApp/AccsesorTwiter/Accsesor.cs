using Tweetinvi;

namespace TwiterAccsessor
{
    public class Accsesor_tw
    {
        public static async Task test()
        {
            
            string APIKey = "lxlnhvHpxhhGYRCeiLz6TyCAM";
            string APISecret = "Myrdl4nTjD8lEPjInOZn1WvIBZ3lqwhI950fJRbBCpdGL6Hi0A";
            string APIToken = "1486277823354621952-UFWBIkGndM1RyH2BvUeRsKicUZCS47";
            string APITokenSecret = "jqyzrRU3hibrsrQrMe3r1uOdXXsoqo5ROBzKVGzJ8RPXK";


            TwitterClient Client = new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);


            Console.WriteLine(await Client.Tweets.PublishTweetAsync("bian "));
        }
    }
}