using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace savePhoto;

public class Function
{
    public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest apiGatewayProxyRequest, ILambdaContext context)
    {   
        context.Logger.LogInformation("Start lambda");
        APIGatewayProxyResponse apiGatewayProxyResponse = new APIGatewayProxyResponse();
        apiGatewayProxyResponse.StatusCode = 200;
        apiGatewayProxyResponse.Body = "{\"teste\":\"teste\"}";

        context.Logger.LogInformation("completed lambda");
        return apiGatewayProxyResponse;
    }
}
