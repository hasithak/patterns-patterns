using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public string Value { get; set; }
        private Singleton()
        {
        }

        public static Singleton SingleInstance
        {
            get
            {
                if (instance == null) 
                { 
                    instance = new Singleton();
                }

                return instance;

            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"value is \"{Value}\"");
        }
    }
}
