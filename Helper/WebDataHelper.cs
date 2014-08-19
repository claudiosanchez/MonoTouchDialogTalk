using System.Net.Http;
using System.Threading.Tasks;

namespace iOS.Data
{
    public class WebDataHelper<T> where T : class
    {
        public async Task<T> GetData(string url)
        {
            var rawData = await new HttpClient().GetStringAsync(url);
            T parsedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(rawData);

            return parsedObject;
        }


    }
}