using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        private HttpClient _client;

        public RonVSKanyeAPI(HttpClient client)
        { _client = client; }

        public string KanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwansonQuote()
        {
            var ronSURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronSResponse = _client.GetStringAsync(ronSURL).Result;

            var ronSQuote = JArray.Parse(ronSResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronSQuote;
        }
    }
}
