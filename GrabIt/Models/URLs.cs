using System;
using System.Text.RegularExpressions;

namespace GrabIt.Models
{
    public class UrLs
    {
        public string LinkShaver(string input)
        {
            if(new Regex("(\\..*){2}").Match(input).Success)
            {
                return new Regex("^(.*?)\\.").Replace(input, "");
            }
            else
            {
                return new Regex("(https:\\/\\/www|http:\\/\\/www|https:\\/\\/|http:\\/\\/|https\\/\\/|http\\/\\/|www)").Replace(input, "");
            }
        }
        
    }
}