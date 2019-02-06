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