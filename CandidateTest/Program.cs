using System;
using System.Text;

namespace CandidateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            while (true)
            {
                Console.WriteLine("Please provide arithmetic expression and press [Enter] ([Escape] to quit):");
                
                var expression = ReadLineWithCancel();

                if (expression is null)
                {
                    break;
                }

                Console.WriteLine();

                var lexer = new Lexer(new DefaultTokenFactory());
                var parser = new Parser(lexer);

                Console.WriteLine(parser.Parse(expression));
            }
        }

        private static string ReadLineWithCancel()
        {
            string result = null;

            StringBuilder buffer = new StringBuilder();

            ConsoleKeyInfo info = Console.ReadKey(true);

            while (info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Escape)
            {
                Console.Write(info.KeyChar);
                buffer.Append(info.KeyChar);
                info = Console.ReadKey(true);
            }

            if (info.Key == ConsoleKey.Enter)
            {
                result = buffer.ToString();
            }

            return result;
        }
    }
}
