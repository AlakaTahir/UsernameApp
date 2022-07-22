using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsernameApp.service;
using UsernameAppmodel;

namespace UsernameApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IShowservice _showService;
        public SampleController(IShowservice showService)
        {
            _showService = showService;
        }

        [HttpPost]
        public IActionResult Show(Namecollectormodel model)
        {
            var result = _showService.DisplaySalutation(model);
            return Ok(result);
        }
    }
}
