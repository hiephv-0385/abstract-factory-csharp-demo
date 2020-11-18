using System;

namespace abstract_factory_demo
{
    public class WinterFashion: IFashion
    {
        public IShoe CreateShoe()
        {
            return new WinterShoe();
        }

        public IDress CreateDress()
        {
            return new WinterDress();
        }
    }
}
