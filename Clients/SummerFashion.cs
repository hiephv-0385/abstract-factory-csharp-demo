using System;

namespace abstract_factory_demo
{
    public class SummerFashion: IFashion
    {
        public IShoe CreateShoe()
        {
            return new SummerShoe();
        }

        public IDress CreateDress()
        {
            return new SummerDress();
        }
    }
}
