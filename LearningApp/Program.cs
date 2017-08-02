using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LearningApp
{
    class Program
    {
        const string Keys = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            var methods = Assembly.GetEntryAssembly()
                            .DefinedTypes
                            .Where(t => t.ImplementedInterfaces.Contains(typeof(IProgram)) && t.IsClass)
                            .Where(t => t.GetConstructors().Where(c => c.IsPublic && c.GetParameters().Length == 0).Count() > 0)
                            .OrderBy(t => GetDescription(t))
                            .Zip(Keys, (ep, k) => new { Key = k, EntryPoint = ep })
                            .ToList();
            if(methods.Count == 0)
            {
                Console.WriteLine("No entry points found. Press return to exit.");
                Console.ReadLine();
                return;
            }

            while(true)
            {
                Console.Clear();
                foreach(var option in methods)
                {
                    Console.WriteLine($"{option.Key}: {GetEntryPointName(option.EntryPoint)}");
                }
                Console.WriteLine();
                Console.Write("Entry point to run (or hit return to quit)? ");

                TypeInfo entryPoint = null;
                do
                {
                    Console.Out.Flush();
                    char key = char.ToUpperInvariant(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if(key == '\r' || key == '\n')
                    {
                        return;
                    }

                    var selected = methods.Find(o => o.Key == key);
                    if(selected == null)
                    {
                        Console.Write("Invalid choice; please select again: ");
                    }
                    else
                    {
                        entryPoint = selected.EntryPoint;
                    }
                } while(entryPoint == null);
                try
                {
                    Activator.CreateInstance(entryPoint.AsType());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: {0}", e);
                }
                Console.WriteLine();
                Console.WriteLine("(Finished; press return.)");
                Console.ReadLine();
            }
        }

        private static object GetEntryPointName(TypeInfo methodBase)
        {
            TypeInfo type = methodBase;
            string description = GetDescription(type);
            return description == null ? type.Name : $"[{description}] {type.Name}";
        }

        private static string GetDescription(TypeInfo type) =>
            type.GetCustomAttributes<DescriptionAttribute>()
                .FirstOrDefault()?.Description;
    }
}