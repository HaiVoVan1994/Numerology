using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumerologyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LifePathNumberController : Controller
    {
        private readonly ILifePathNumber _lifePathNumber;
        public LifePathNumberController(ILifePathNumber lifePathNumber)
        {
            _lifePathNumber = lifePathNumber;
        }

        [HttpGet]
        public IActionResult GetLifePathNumber(string birthday)
        {
            var lifePathNumber = _lifePathNumber.GetLifePathNumber(birthday);
            return Ok($"Your life path number: {lifePathNumber}");
        }
    }
}
