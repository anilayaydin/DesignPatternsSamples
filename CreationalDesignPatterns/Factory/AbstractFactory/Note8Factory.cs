using System;

namespace Factory
{
    class Note8Factory : PhoneFactoryInterface
    {
        public Phone GetPhone(string model,string battery, int width, int height){
            return new Note8(model,battery,width,height);
        }
        
    }
}