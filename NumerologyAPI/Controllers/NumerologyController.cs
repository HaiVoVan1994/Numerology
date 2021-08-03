using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumerologyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumerologyController : Controller
    {
        [HttpGet]
        public IActionResult GetLifePathNumber(string birthday)
        {
            if (string.IsNullOrEmpty(birthday)) {
                throw new ArgumentException("Your birthday cannot be empty");
            }

            var birthdayInt = 0;
            if (!int.TryParse(birthday, out birthdayInt)) {
                throw new ArgumentException("Your birthday format is not valid, valid format is : ddmmyyyy");
            };
            // ToDo validate exactly birthday

            var lifePathNumber = birthdayInt;
            while (lifePathNumber > 10)
            {
                lifePathNumber = lifePathNumber.ToString().Sum(x => x - '0');
            }

            return Ok($"Your life path number: {lifePathNumber}");
        }
    }
}
