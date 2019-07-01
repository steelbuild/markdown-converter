using System;
using markdown_to_html;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Converter();
            Console.WriteLine(c.Execute("**Hello**"));
        }
    }
}
