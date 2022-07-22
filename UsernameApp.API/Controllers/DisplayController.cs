using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsernameApp.service;
using UsernameAppmodel;

namespace UsernameApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        private readonly IShowservice _showService;

        public DisplayController(IShowservice showService)
        {
            _showService = showService;
        }

        [HttpPost]
        public IActionResult DisplaySalutation(Namecollectormodel model)
        {
         var result = _showService.DisplaySalutation(model);
         return Ok(result);
        }
    }
}
