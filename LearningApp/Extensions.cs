using System;
using System.ComponentModel;
using System.Linq;

namespace LearningApp
{
    public class Extensions : IProgram
    {
        public Extensions()
        {
            StringExtensions();
        }

        private void StringExtensions()
        {
            Console.WriteLine("hello".Capitalize());
            Console.WriteLine("Hi".IsCapitalized());
            Console.WriteLine("hEllo".IsCapitalized());
        }
    }

    internal static class StringExtensions
    {
        internal static string Capitalize(this string str)
        {
            var letter = Char.ToUpper(str[0]);
            return letter + str.Substring(1);
        }

        internal static bool IsCapitalized(this string str)
        {
            return Char.IsUpper(str[0]);
        }
    }
}