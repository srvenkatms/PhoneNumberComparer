using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Solve
{
    public static class Compare
    {
        [FunctionName("Compare")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            DataModel data = JsonConvert.DeserializeObject<DataModel>(requestBody);
           string phone1 = data.phone1;
           string phone2 = data.phone2;

            string responseMessage = "";
            if(string.IsNullOrEmpty(phone1) || string.IsNullOrEmpty(phone2))
            {
                responseMessage = " Either phone1 or phone 2 is empty";
                return new OkObjectResult(responseMessage);
            }
           
            bool result = Helper.CheckSequence(phone1,phone2);
            responseMessage = result? " Phone numbers match" : "Phone numbers doesnt match";
            return new OkObjectResult(responseMessage);
        }
    }
}
