using System;

namespace IntralismMapSpeedChanger
{
    public static class ConsoleDataPuller
    {
        public delegate bool OutPredicate<in T, T2>(T obj, out T2 val);
        
        public static T Get<T>(string askingMessage, string errorMessage, OutPredicate<string, T> predicate)
        {
            Console.WriteLine(askingMessage);

            T value;
            while (predicate(Console.ReadLine(), out value))
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }

            return value;
        }
    }
}