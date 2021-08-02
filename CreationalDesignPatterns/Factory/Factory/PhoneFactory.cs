using System;

namespace Factory
{
    class PhoneFactory
    {
        
        public static Phone GetPhone(string model, string battery, int width, int height)
        {
            Phone phone;

            if(model.Equals("S8",StringComparison.OrdinalIgnoreCase))
            {
                phone = new S8(model,battery,width,height);
            }

            else if(model.Equals("Note8",StringComparison.OrdinalIgnoreCase))
            {
                phone = new Note8(model,battery,width,height);
            }

            else
            {
                throw new Exception("This is not a valid phone model.");
            }

            return phone;
        }
    }
}