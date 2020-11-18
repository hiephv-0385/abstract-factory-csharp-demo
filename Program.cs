using System;

namespace abstract_factory_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract factory demo:");
            Console.WriteLine("**********");

            var client = new Client();

            client.ClientMethod(new SummerFashion());

            client.ClientMethod(new WinterFashion());
        }
    }
}
