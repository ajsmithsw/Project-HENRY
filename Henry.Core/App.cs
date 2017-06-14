using System;
using Henry.Core.Services;

namespace Henry.Core
{
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
