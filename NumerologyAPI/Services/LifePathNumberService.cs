using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumerologyAPI.Services
{
    public class LifePathNumberService : ILifePathNumber
    {
        public int GetLifePathNumber(string birthday)
        {
            // Check empty
            if (string.IsNullOrEmpty(birthday))
            {
                throw new ArgumentException("Your birthday cannot be empty");
            }

            // Check interger
            var birthdayInt = 0;
            if (!int.TryParse(birthday, out birthdayInt))
            {
                throw new ArgumentException("Your birthday format is not valid, valid format is : ddmmyyyy");
            }

            // Check format
            var regex = new Regex(@"^([0-2][0-9]|(3)[0-1])(((0)[0-9])|((1)[0-2]))\d{4}$");
            if (!regex.IsMatch(birthday))
            {
                throw new ArgumentException("Your birthday format is not valid, valid format is : ddmmyyyy");
            }

            var lifePathNumber = birthdayInt;
            while (lifePathNumber > 10)
            {
                lifePathNumber = lifePathNumber.ToString().Sum(x => x - '0');
            }

            return lifePathNumber;
        }
    }
}
