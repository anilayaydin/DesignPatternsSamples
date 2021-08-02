using System;

namespace Factory
{
    class S8Factory : PhoneFactoryInterface
    {
        public Phone GetPhone(string model,string battery, int width, int height){
            return new S8(model,battery,width,height);
        }
        
    }
}