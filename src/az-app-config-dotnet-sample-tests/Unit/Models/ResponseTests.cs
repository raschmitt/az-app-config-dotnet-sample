using FluentAssertions;
using unleash_dotnet_sample.Models;
using Xunit;

namespace unleash_dotnet_sample_tests.Unit.Models
{
    public class ResponseTests
    {
        [Fact]
        public void Should_create_response()
        {
            // Arrange
            var featureToggle = "Sample";
            var value = true;
            
            // Act
            var response = new Response(featureToggle, value);

            response.FeatureToggle.Should().Be(featureToggle);
            response.Value.Should().Be(value);
        }
    }
}