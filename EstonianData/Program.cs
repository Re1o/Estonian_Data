using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace EstonianData
{
    class Program
    {
        static void Main(string[] args)
        {
            string userDataUrl = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(userDataUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                ESTdata eSTdata = JsonConvert.DeserializeObject<ESTdata>(response);
                Console.WriteLine(eSTdata.Value);
                Console.WriteLine(eSTdata.Status);
                Console.WriteLine($"name: {eSTdata.Results.name}");
                Console.WriteLine($"cioc: {eSTdata.Results.cioc}");
                Console.WriteLine($"domain: {eSTdata.Results.domain}");
                Console.WriteLine($"capital: {eSTdata.Results.capital}");
                Console.WriteLine($"region: {eSTdata.Results.region}");
                Console.WriteLine($"population: {eSTdata.Results.population}");
                Console.WriteLine($"language: {eSTdata.Results.language}");



            }
        }
    }
}
