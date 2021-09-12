using System.Text.RegularExpressions;

namespace GrabIt.Models
{
    public class General
    {
        public static string LowerCaseAndSpaceReplace(string input)
        {
            return new Regex("^[ \t]+|[ \t]+$").Replace(input.ToLower(), "");
        }
    }
}