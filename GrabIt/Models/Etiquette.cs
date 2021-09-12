using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GrabIt.Models
{
    public class Etiquette
    {
        public static string ProfanityFilter(string rant, Dictionary<string, string> dict)
        {
            List<string> RantAsList;
            RantAsList = rant.Split(" ").ToList();
            using StreamReader r = new StreamReader("ProfanityDictionary.json");
            dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(r.ReadToEnd());
            RantAsList.ForEach(word => word.Replace(word, dict != null && dict.TryGetValue(word, out rant) ? rant : ""));
            return string.Join(" ", RantAsList);
        }
    }
}