using System;

namespace Factory
{
    interface PhoneFactoryInterface
    {
        Phone GetPhone(string model, string battery, int width, int height);
    }
}