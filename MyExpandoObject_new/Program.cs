using System;
using System.Collections.Generic;

namespace MyExpandoObject_new
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic viewBag = new System.Dynamic.ExpandoObject();
            viewBag.Name = "Tom";
            viewBag.Age = 36;
            viewBag.Languages = new List<string> {"English", "German", "French" };
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
            foreach(var lang in viewBag.Languages)
            {
                Console.WriteLine(lang);
            }

            viewBag.IncrementAge = (Action<int>)(x => viewBag.Age += x);
            viewBag.IncrementAge(6);
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
            Console.ReadKey();
        }
    }
}
