using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Singleton.SingleInstance;
            instance.Value = "value set :D";
            instance.PrintDetails();

            var instance2 = Singleton.SingleInstance;
            instance2.PrintDetails();

            var instance3 = Singleton.SingleInstance;
            instance3.PrintDetails();
        }
    }
}
