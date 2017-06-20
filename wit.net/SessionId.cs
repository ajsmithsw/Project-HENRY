using System;
using System.Linq;

namespace WitAi
{
    public static class SessionId
    {
        static readonly Random random = new Random();

        public static string Generate()
        {
            var chars = "012345678901234567890123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijlmnopqrstuvwxyz".ToCharArray();

            return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
