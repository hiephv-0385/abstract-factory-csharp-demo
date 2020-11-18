using System;

namespace abstract_factory_demo
{
    public class SummerShoe: IShoe
    {
        public string GetName()
        {
            return "Summer shoe";
        }

        public string GetModel()
        {
            return "This is summer shoe";
        }
    }
}
