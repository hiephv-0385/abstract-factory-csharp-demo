using System;

namespace abstract_factory_demo
{
    public class Client
    {
        public void ClientMethod(IFashion factory)
        {
            var shoe = factory.CreateShoe();
            var dress = factory.CreateDress();

            Console.WriteLine(shoe.GetModel());
            Console.WriteLine(shoe.GetName());

            Console.WriteLine(dress.GetModel());
            Console.WriteLine(dress.GetName());

            Console.WriteLine("**********");
        }
    }
}
