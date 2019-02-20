# aws-lambda-function

Example C# though .Net Core 2 working with AWS Lambda Function

## This code to show about

- Simple code to explain about lambda
- Dependency Injection
- Unit Test

## If you integrate with API Gateway

1. go to Method Request > URL Query String Parameters and set parameter "name"
2. go to Integration Request > Mapping Templates and select "When there are no templates defined (recommended)", and create type "application/json" and enter input

```json
"$input.params('name')"
```

## Test and Deploy with AWS CLI

**Try to Run and Get result**
```
$ cd src/aws-lambda-function
$ aws lambda invoke --function-name {LAMBDA_FUNCTION_NAME} output.txt
```

**Deploy**
```
$ cd src/aws-lambda-function
$ dotnet lambda deploy-function {LAMBDA_FUNCTION_NAME} –-function-role {ROLE_NAME}
```

## Test on local machine via Docker Lambda

Install Docker first!

```
$ cd src/aws-lambda-function
$ dotnet publish -c Release
$ cs bin/Release/netcoreapp2.1/publish
$ docker run --rm -v "$PWD":/var/task lambci/lambda:dotnetcore2.1 aws-lambda-function::aws_lambda_function.Function::FunctionHandler '"iFew"'
```