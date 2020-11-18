using System;

namespace abstract_factory_demo
{
    public class WinterDress: IDress
    {
        public string GetName()
        {
            return "Winter Dress";
        }

        public string GetModel()
        {
            return "This is winter dress";
        }
    }
}
