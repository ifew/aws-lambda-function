using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace aws_lambda_function
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a Name in string and does a Hello Name
        /// </summary>
        /// <param name="inputName"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(string inputName, ILambdaContext context)
        {
            var data = new HelloModel {
                message = Hello(inputName)
            };

            APIGatewayProxyResponse respond = new APIGatewayProxyResponse {
                StatusCode = (int)HttpStatusCode.OK,
                Headers = new Dictionary<string, string>
                { 
                    { "Content-Type", "application/json" }, 
                    { "Access-Control-Allow-Origin", "*" } 
                },
                Body = JsonConvert.SerializeObject(data)
            };

            return respond;
        }

        public string Hello(string name)
        {
            return "Hello, " + name;
        }

    }
}
