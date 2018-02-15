using System;
using System.ComponentModel;
using System.Linq;
using LearningApp.Contracts;

namespace LearningApp.Applications
{
    [Description("CodeWars Test")]
    public class CodeWars : IProgram
    {
        public CodeWars()
        {
            var array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(CreatePhoneNumber(array));
        }

        public int Find(int[] integers)
        {
            if (integers.Count(i => i % 2 == 0) == 1)
                return integers.SingleOrDefault(i => i % 2 == 0);

            return integers.SingleOrDefault(i => i % 2 == 1);
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}{10}", numbers.Select(n => n.ToString()).ToArray());
        }
    }
}
