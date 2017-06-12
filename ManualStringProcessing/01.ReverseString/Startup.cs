using System;
using System.Text;

namespace _01.ReverseString
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
