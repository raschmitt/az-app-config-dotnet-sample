using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using NSubstitute;
using unleash_dotnet_sample.Controllers;
using Xunit;

namespace unleash_dotnet_sample_tests.Unit.Controllers
{
    public class AppConfigControllerTests
    {
        private readonly IFeatureManager _featureManager;
        private readonly AppConfigController _appConfigController;

        public AppConfigControllerTests()
        {
            _featureManager = Substitute.For<IFeatureManager>();
            
            _appConfigController = new AppConfigController(_featureManager);
        }
        
        [Fact]
        public async Task Should_get_feature_toggle()
        {
            // Arrange
            var featureToggle = "Sample";

            // Act
            var response = await _appConfigController.Get(featureToggle);

            // Assert
            response.Should().BeOfType<OkObjectResult>();

            await _featureManager.Received(1).IsEnabledAsync(featureToggle);
        }
    }
}