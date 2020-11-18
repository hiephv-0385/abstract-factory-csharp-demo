using System;

namespace abstract_factory_demo
{
    public interface IFashion
    {
        IShoe CreateShoe();

        IDress CreateDress();
    }
}
