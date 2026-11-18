using DemoApi.Services;

namespace DemoApi.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void GetMessage_ShouldReturnCorrectMessage()
    {
        // Arrange
        var service = new GreetingService();

        // Act
        var result = service.GetMessage();

        // Assert
        Assert.Equal(
            "Hello from .NET CI/CD!",
            result
        );
    }
}