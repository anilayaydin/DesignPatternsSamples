using System;

namespace Builder{
    public class House:HouseBuilder
    {
        private string city;
        private string town;
        private string neighborhood;
        private int room;
        private int bath;
        private int toilet;
        private int balcony;
        private int age;
        private bool isDublex;
        private bool isFurnitured;
        private bool hasAutopark;
        private bool hasChildPark;
        private bool hasClimate;
        private bool hasPool;

        public House(string city,string town,string neighborhood,int room,int bath,int toilet,int balcony,int age, bool isDublex,bool isFurnitured,bool hasAutopark,bool hasChildPark,bool hasClimate,bool hasPool)
        {
            this.city=city;
            this.town=town;
            this.neighborhood=neighborhood;
            this.room=room;
            this.bath=bath;
            this.toilet=toilet;
            this.balcony=balcony;
            this.age=age;
            this.isDublex=isDublex;
            this.isFurnitured=isFurnitured;
            this.hasAutopark=hasAutopark;
            this.hasChildPark=hasChildPark;
            this.hasClimate=hasClimate;
            this.hasPool=hasPool;
        }

        public House()
        {
            
            
        }

        

    }

    
}