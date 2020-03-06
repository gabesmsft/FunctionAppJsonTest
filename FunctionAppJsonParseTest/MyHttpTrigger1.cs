using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace FunctionAppJsonParseTest
{
    public static class MyHttpTrigger1
    {
        [FunctionName("MyHTTPTrigger1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            //someMessage represents some json data being sent to the app. am hard-coding this for simplicity
            //for demo purposes
            var someMessage = @"{
""MyEnum"": ""AZURE_RESOURCE_PROVIDER_THROTTLING""
}";
            var runArgs = JsonConvert.DeserializeObject<MyDataClass>(someMessage);
            
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
