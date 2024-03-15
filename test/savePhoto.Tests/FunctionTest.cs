using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

namespace savePhoto.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        var function = new Function();
        var context = new TestLambdaContext();
        APIGatewayProxyRequest apiGatewayProxyRequest = new APIGatewayProxyRequest();
        apiGatewayProxyRequest.Body = "{xpto}";
        APIGatewayProxyResponse apiGatewayProxyResponse = function.FunctionHandler(apiGatewayProxyRequest, context);

        Assert.Equal(200, apiGatewayProxyResponse.StatusCode);
    }
}
