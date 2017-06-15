using System;
using System.Linq;

namespace Henry.Core.Utils
{
    public static class SessionId
    {
        private static readonly Random random = new Random();

        public static string Generate()
        {
            var chars = "012345678901234567890123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijlmnopqrstuvwxyz".ToCharArray();

			return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());

        }
    }
}
