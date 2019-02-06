using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using aws_lambda_function;
using Newtonsoft.Json;

namespace aws_lambda_function.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestFunctionMethod()
        {
            string expected = "{\"message\":\"Hello, iFew\"}";


            var function = new Function();
            var context = new TestLambdaContext();
            var hello_result = function.FunctionHandler("iFew", context);

            Assert.Equal(expected, hello_result.Body);
        }

        [Fact]
        public void TestHelloMethod()
        {
            string input = "iFew";
            string expected = "Hello, iFew";

            var function = new Function();
            string hello_result = function.Hello(input);

            Assert.Equal(expected, hello_result);
        }
    }
}
