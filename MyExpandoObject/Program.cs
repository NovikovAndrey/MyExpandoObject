using System;
using System.Collections.Generic;
using System.Text;

namespace MyExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic viewbag = new System.Dynamic.ExpandoObject();
            viewbag.Name = "Tom";
            viewbag.Age = 46;
            viewbag.Languages = new List<string> { "english", "german", "french" };
            Console.WriteLine($"{viewbag.Name} - {viewbag.Age}");
            foreach (var lang in viewbag.Languages)
                Console.WriteLine(lang);

            // объявляем метод
            viewbag.IncrementAge = (Action<int>)(x => viewbag.Age += x);
            viewbag.IncrementAge(6); // увеличиваем возраст на 6 лет
            Console.WriteLine($"{viewbag.Name} - {viewbag.Age}");

            Console.ReadLine();
        }
    }
}
