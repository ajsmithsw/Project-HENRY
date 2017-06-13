using System;
using Henry.Core;
using Henry.Core.Services;

namespace Henry
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var app = new App();
            app.Init();
        }
    }

    public class App
    {
        WitService _witService;

        public void Init()
        {
			bool exited = false;

			_witService = new WitService();

			while (!exited)
			{

				Console.WriteLine("Your message:");

				var input = Console.ReadLine();

				if (input == "exit") return;

				Console.WriteLine("I said: \'{0}\'", input);

                var result = _witService.Message(input);

				Console.WriteLine(result);
			}
        }
    }
}
