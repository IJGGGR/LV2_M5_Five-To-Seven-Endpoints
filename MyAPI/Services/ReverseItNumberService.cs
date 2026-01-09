using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class ReverseItNumberService
    {
        public string ReverseIt(string arg)
        {
            char[] arr = arg.ToCharArray();
            if (!Array.TrueForAll(arr, e => e.Equals('0') || e.Equals('1') || e.Equals('2') || e.Equals('3') || e.Equals('4') || e.Equals('5') || e.Equals('6') || e.Equals('7') || e.Equals('8') || e.Equals('9')))
            {
                return "Error: Numbers only.";
            }
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
