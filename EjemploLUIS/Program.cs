using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EjemploLUIS
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpclient = new HttpClient();
            var query = "hola me llamo william y tengo 23 años";
            var result = await httpclient.GetStringAsync("https://proyectovanguardia.cognitiveservices.azure.com/luis/prediction/v3.0/apps/bad92a72-8f96-4db8-b457-cded762e6a21/slots/production/predict?subscription-key=be1b4a87a109432daf5434da9e38ee89&verbose=true&show-all-intents=true&log=true&query="+query);
            var luisResponse = JsonConvert.DeserializeObject<LuisResponse>(result);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
