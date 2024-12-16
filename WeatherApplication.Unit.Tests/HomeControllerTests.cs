namespace WeatherApplication.Unit.Tests;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using WeatherApplication.Controllers;

public class HomeControllerTests
{
    [Fact]
    public void IndexReturnsAViewResult()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<HomeController>>();
        var controller = new HomeController(mockLogger.Object);

        // Act
        var result = controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
               Assert.Null(viewResult.ViewName); // Default view name is null
    }
}
