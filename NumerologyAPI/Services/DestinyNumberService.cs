using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumerologyAPI.Services
{
    public class DestinyNumberService : IDestinyNumber
    {
        private readonly Dictionary<int, string> CharToDestinyNumber = new Dictionary<int, string>
        {
            { 1, "A,J,S" },
            { 2, "B,K,T" },
            { 3, "C,L,U" },
            { 4, "D,M,V" },
            { 5, "E,N,W" },
            { 6, "F,O,X" },
            { 7, "G,P,Y" },
            { 8, "H,Q,Z" },
            { 9, "I,R" },
        };

        public int GetDestinyNumber(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new Exception("Please provide your full name");
            }
            //ToDo check num-alphabet

            var number = 0;
            fullName = Regex.Replace(fullName, @"\s+", "").ToUpper();
            for (int i = 0; i < fullName.Length; i++)
            {
                number += CharToDestinyNumber.FirstOrDefault(val => val.Value.Contains(fullName[i].ToString())).Key;
            }

            while (number > 10)
            {
                number = number.ToString().Sum(x => x - '0');
            }

            return number;
        }
    }
}
