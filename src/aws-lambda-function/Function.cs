using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

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
        public respondModel FunctionHandler(string inputName, ILambdaContext context)
        {
            respondModel respond = new respondModel {
                http_code = "200",
                http_message = "Success",
                body = new HelloModel {
                    message = Hello(inputName)
                }
            };

            return respond;
        }

        public string Hello(string name)
        {
            return "Hello, " + name;
        }

    }
}
