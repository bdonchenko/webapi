using Microsoft.Extensions.Logging;
using WebApi.Controllers;
using Xunit;
using Moq;
using System.Linq;

namespace WebApi.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly WeatherForecastController sut;

        public WeatherForecastControllerTests() {
            var logger = new Mock<ILogger<WeatherForecastController>>();  
            sut = new WeatherForecastController(logger.Object);
        }

        [Fact]
        public void Get_Test()
        {
            var result = sut.Get();
            Assert.Equal(5, result.Count());
        }
    }
}
