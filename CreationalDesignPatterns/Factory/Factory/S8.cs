using System;

namespace Factory
{
    public class S8 : Phone
    {
        private string model;
        private string battery;
        private int width;
        private int height;

        public S8(string model,string battery,int width,int height)
        {
            this.model=model;
            this.battery=battery;
            this.width=width;
            this.height=height;
        }

        public string getModel() {
            return model;
        }

        public string getBattery(){
            return battery;
        }

        public int getWidth(){
            return width;
        }
        public int getHeight()
        {
            return height;
        }
        
    }
}