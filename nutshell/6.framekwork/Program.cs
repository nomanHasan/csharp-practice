using System;
using System.Globalization;

public class console {
    public static void log(string value) {
        Console.WriteLine(value);
    }
}

namespace _6.framekwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToUniversalTime().ToString());
            Console.WriteLine(dt.Ticks);
            Console.WriteLine(dt.Kind);


            TimeZoneInfo wa = TimeZoneInfo.Local;

            Console.WriteLine(wa.Id);
            Console.WriteLine(wa.StandardName);
            Console.WriteLine(wa.DaylightName);
            Console.WriteLine(wa.BaseUtcOffset);
            Console.WriteLine(wa.Id);


            Console.WriteLine(103.214.ToString("C", CultureInfo.GetCultureInfo("bn-BD")));
            

            console.log("W");

            Console.WriteLine(System.Environment.UserDomainName);
            console.log(System.Environment.UserName);

        }
    }
}
