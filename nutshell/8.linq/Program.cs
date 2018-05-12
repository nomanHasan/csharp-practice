using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _8.linq {
    class Program {
        static void Main (string[] args) {
            string[] names = {
                "kuddus",
                "Miah",
                "Mokbul",
                "Abdul",
                "Mofiz",
                "Shamsu",
                "Bodu",
                "Motin"
            };

            log ("Greater than 2", names.Where (x => x.Length > 2));

            log ("Greater than 2", from n in names where n.Length > 2 select n);

            log ("Length", names.OrderBy (x => x.Length));

            log ("Length", from n in names orderby n.Length select n);

            log ("Minimum Length String", names.Where (n => n.Length == names.Select (x => x.Length).Min ()));

            log ("Minimum Length String", from n in names where n.Length == names.Max (x => x.Length) select n);

            log ("Replace Vowel", names.Select (n => n.Replace ("a", "").Replace ("e", "").Replace ("i", "")
                .Replace ("o", "").Replace ("u", "")));

            IEnumerable<IDictionary<string, string>> obs = names.Select (x => new Dictionary<string, string> { { "Original", x },
                { "VowlLess", Regex.Replace (x, "[aeiou]", "") }
            });

            log ("Dictionary", obs);

        }

        static void log (IEnumerable<string> strings) {
            foreach (var s in strings) {
                Console.Write (s + ", ");
            }
        }

        static void log (string title, IEnumerable<string> strings) {
            Console.WriteLine ();
            Console.WriteLine (title + ": ");
            foreach (var s in strings) {
                Console.Write (s + ", ");
            }
        }

        static void log (string title, IEnumerable<IDictionary<string, string>> obs) {
            Console.WriteLine ();
            Console.WriteLine (title + ": ");
            foreach (var s in obs) {
                Console.WriteLine (s.Keys + ": " + s.Values);
            }
        }

    }
}