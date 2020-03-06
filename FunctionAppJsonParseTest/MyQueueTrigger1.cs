using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionAppJsonParseTest
{
    public static class MyQueueTrigger1
    {
        [FunctionName("MyQueueTrigger1")]
        public static void Run([QueueTrigger("myqueue", Connection = "MyConnectionString")]string myQueueItem, ILogger log)
        {
            var runArgs = JsonConvert.DeserializeObject<MyDataClass>(myQueueItem);
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
