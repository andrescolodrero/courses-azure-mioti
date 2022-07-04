using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace http_dotnet_cicd
{
    public class queue_example
    {
        [FunctionName("queue_example")]
        public void Run([QueueTrigger("myqueue-items", Connection = "connection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
