using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumerologyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinyNumberController : Controller
    {
        private readonly IDestinyNumber _destinyNumber;
        public DestinyNumberController(IDestinyNumber destinyNumber)
        {
            _destinyNumber = destinyNumber;
        }

        [HttpGet]
        public IActionResult GetDestinyNumber(string fullName)
        {
            _destinyNumber.GetDestinyNumber(fullName);
            return Ok("");
        }
    }
}
