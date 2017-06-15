using System;
using System.Diagnostics;
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
				Console.Write("\nYou   > ");

                var input = Console.ReadLine();

                Debug.WriteLine(input);

				if (input == "exit") return;

				var result = _witService.Converse(input);

                Console.WriteLine("\nHENRY > {0}", result);
			}
		}
	}
}
