﻿using System;
using System.Diagnostics;
using Henry.Core.Services;
using WitAi;

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
	                _witService.BeginInteraction();
			    }
                catch (Exception e)
                {
                    Debug.WriteLine("Error: {0}", e.Message);

                    return;
                }
            }
		}
	}
}
