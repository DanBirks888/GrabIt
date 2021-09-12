using System;
using System.Text.RegularExpressions;

namespace GrabIt.Models
{
    public class UrLs
    {
        public string LinkShaver(string input)
        {
            return new Regex("^(.*?)\\.").Replace(input, "");
        }
        
    }
}