using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(double num)
        {
            if (num % 2 == 0)
            {
                return $"{num} is even.";
            }
            else
            {
                return $"{num} is odd.";
            }
        }
    }
}
