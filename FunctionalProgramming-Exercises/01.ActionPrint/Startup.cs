namespace _01.ActionPrint
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Action<string> print = str => Console.WriteLine(str);

            Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}
