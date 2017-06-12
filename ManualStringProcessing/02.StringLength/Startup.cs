namespace _02.StringLength
{
    using System;

    class Startup
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string paddedText = text.PadRight(20, '*');
            Console.WriteLine(paddedText);
        }
    }
}
