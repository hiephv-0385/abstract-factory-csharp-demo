using System;

namespace abstract_factory_demo
{
    public class WinterShoe: IShoe
    {
        public string GetName()
        {
            return "Winter shoe";
        }

        public string GetModel()
        {
            return "This is winter shoe";
        }
    }
}
