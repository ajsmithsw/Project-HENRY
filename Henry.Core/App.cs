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

				if (input == "exit") return;

				_witService.Converse(input);
			}
		}
	}
}
