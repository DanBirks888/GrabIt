using System;
using System.Text.RegularExpressions;

namespace GrabIt.Models
{
    public class UrLs
    {
        public string LinkShaver(string input)
        {
            // If it has more than one dot
            if(new Regex("(\\..*){2}").Match(input).Success)
            {
                return new Regex("^(.*?)\\.").Replace(input, "");
            }
            // If it doesnt not have multiple dots
            else
            {
                return new Regex("(https:\\/\\/www|http:\\/\\/www|https:\\/\\/|http:\\/\\/|https\\/\\/|http\\/\\/|www)").Replace(input, "");
            }
        }
        
    }
}