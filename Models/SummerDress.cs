using System;

namespace abstract_factory_demo
{
    public class SummerDress: IDress
    {
        public string GetName()
        {
            return "Summber dress";
        }

        public string GetModel()
        {
            return "This is summer dress";
        }
    }
}
