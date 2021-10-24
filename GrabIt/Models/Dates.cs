namespace GrabIt.Models
{
    public class Dates
    {
        public static string GetDateOrdinal(string date) {

            if (date.EndsWith("11") || date.EndsWith("12") || date.EndsWith("13")) return $"{date}th";
            
            if (date.EndsWith("1")) return $"{date}st";

            if (date.EndsWith("2")) return $"{date}nd";

            if (date.EndsWith("3")) return $"{date}rd";

            return $"{date}th";

        }
        
        
    }
} 