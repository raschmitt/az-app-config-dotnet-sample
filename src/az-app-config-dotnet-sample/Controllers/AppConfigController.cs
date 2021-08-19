using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using unleash_dotnet_sample.Models;

namespace unleash_dotnet_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppConfigController : ControllerBase
    {
        private readonly IFeatureManager _featureManager;

        public AppConfigController(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }
        
        [HttpGet("{featureToggle}")]
        public async Task<IActionResult> Get([FromRoute] string featureToggle)
        {
            var response = new Response(featureToggle, await _featureManager.IsEnabledAsync(featureToggle));
            
            return Ok(response);
        }
    }
}