using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class ReverseItStringService
    {
        public string ReverseIt(string arg)
        {
            char[] arr = arg.ToCharArray();
            Array.Reverse(arr);
            return $"{arg} -> {new string(arr)}";
        }
    }
}
