using System;
using Henry.Core;
using Henry.Core.Wit;

namespace Henry
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool exited = false;

            while (!exited)
            {
                Console.WriteLine("Your message:");

                var input = Console.ReadLine();

                if (input == "exit") return;

                Console.WriteLine("I said: \'{0}\'\n", input);

                var result = WitClient.Message(input);

                Console.WriteLine(result);
            }
        }
    }
}
