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
			_witService = new WitService();

			while (true)
			{
                try
                {
					Console.Write("\nYou   > ");
	                _witService.Go();
			    }
                catch
                {
                    return;
                }
            }
		}
	}
}
