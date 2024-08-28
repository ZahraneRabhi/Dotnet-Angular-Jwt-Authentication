using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace JwtAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { access= "Granted", message = "This Secure Endpoint can only be accessed when a user is logged in" });
        }

        [HttpGet("data")]
        public IActionResult Data()
        {
            var heroes = new List<object>
            {
                new { Name = "Homelander", ThreatLevel = "Extreme", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/5/5b/Homelander-S4.png/revision/latest?cb=20240614091600" },
                new { Name = "Queen Maeve", ThreatLevel = "High", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/2/27/Queen-Maeve-S3.png/revision/latest?cb=20220604010748" },
                new { Name = "A-Train", ThreatLevel = "Moderate", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/4/4c/A-Train-S4.png/revision/latest?cb=20240614091725" },
                new { Name = "Starlight", ThreatLevel = "Moderate", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/c/cb/Annie_January-S4.png/revision/latest?cb=20240614091322"  },
                new { Name = "Black Noir", ThreatLevel = "High", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/6/69/Black-Noir-S4.png/revision/latest?cb=20240827035512" },
                new { Name = "The Deep", ThreatLevel = "Low", ImageSrc = "https://static.wikia.nocookie.net/amazons-the-boys/images/8/84/Deep-S4.png/revision/latest?cb=20240614091826" }
            };

            return Ok(heroes);
        }
    }
}
