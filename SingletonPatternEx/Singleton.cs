using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternEx
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstance = 0;
        public static int MyInt = 25;

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
                return instance;
            }
        }
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor");
            numberOfInstance++;
            Console.WriteLine("Number of instances ={0}", numberOfInstance);
        }
    }
}
