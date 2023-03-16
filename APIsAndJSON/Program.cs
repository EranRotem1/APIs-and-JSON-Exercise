namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new RonVSKanyeAPI(client);
            var weather = new OpenWeatherMapAPI(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: \"{quote.KanyeQuote()}\"");
                Console.WriteLine($"Ron Swanson: {quote.RonSwansonQuote()}");
            }

            Console.WriteLine(weather.GetWeatherDetails("Chicago"));
        }
    }
}
