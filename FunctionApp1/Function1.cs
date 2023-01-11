using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Microsoft.Azure.Compute.Fundamentals.GuestHealthReporting.HealthStoreSignalUpload
{
    public class HealthStoreSignalUpload
    {
        [FunctionName("HealthStoreSignalUpload")]
        public static void Run([BlobTrigger("signals/{name}", Connection = "SIGNALS_STORAGE")] Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
