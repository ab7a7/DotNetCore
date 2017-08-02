using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace LearningApp
{
    [Description("ABC")]
    public class FirstProgram : IProgram
    {
        public FirstProgram()
        {
            ChangeArrayFirstIndex();
            FirstOrDefaultvsFind();
        }

        private void FirstOrDefaultvsFind()
        {
            List<string> names = new List<string>{ "Tom", "Steven", "Mary", "Joe", "Naz", "Tarranveer", "Singh", "Matt", "Kels", "Dave", "David"};
            var items = new List<Person>();
            Random rnd = new Random();
            for(int i = 0; i < 1000; i++)
            {

                items.Add(new Person{ Id = i, Name = names[rnd.Next(names.Count - 1)], Age = rnd.Next(100) });
            }
            var watch = new Stopwatch();
            watch.Start();
            var item = items.FirstOrDefault(p => p.Name == "Steven");
            watch.Stop();
            Console.WriteLine($"Time Taken with FirstOrDefault: {watch.Elapsed}");

            watch.Restart();
            var newItem = items.Find(p => p.Name == "Naz");
            watch.Stop();
            Console.WriteLine($"Time Taken with Find: {watch.Elapsed}");
        }

        private void ChangeArrayFirstIndex()
        {
            var a = Array.CreateInstance(typeof(string), new int[] { 2 }, new int[] { 1 });
            a.SetValue("a", 1);
            a.SetValue("b", 2);

            try
            {
                Console.WriteLine(a.GetValue(0));
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Array has index of 1");
            }
            Console.WriteLine(a.GetValue(1));
        }

        private class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
