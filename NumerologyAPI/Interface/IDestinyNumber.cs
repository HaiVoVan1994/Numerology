using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumerologyAPI
{
    public interface IDestinyNumber
    {
        int GetDestinyNumber(string fullName);
    }
}
