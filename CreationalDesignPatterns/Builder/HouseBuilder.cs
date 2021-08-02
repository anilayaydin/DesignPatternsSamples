using System;

namespace Builder{
    public class HouseBuilder
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

        // public HouseBuilder(HouseBuilder houseBuilder)
        // {
        //     this.city=houseBuilder.city;
        //     this.town=houseBuilder.town;
        //     this.neighborhood=houseBuilder.neighborhood;
        //     this.room=houseBuilder.room;
        //     this.bath=houseBuilder.bath;
        //     this.toilet=houseBuilder.toilet;
        //     this.balcony=houseBuilder.balcony;
        //     this.age=houseBuilder.age;
        //     this.isDublex=houseBuilder.isDublex;
        //     this.isFurnitured=houseBuilder.isFurnitured;
        //     this.hasAutopark=houseBuilder.hasAutopark;
        //     this.hasChildPark=houseBuilder.hasChildPark;
        //     this.hasClimate=houseBuilder.hasClimate;
        //     this.hasPool=houseBuilder.hasPool;

        // }

        public static HouseBuilder startBuild()
        {
            return new HouseBuilder();
        }

        public House build()
        {
            House house = new House();
            house.setCity(city);
            house.setTown(town);
            house.setNeighborhood(neighborhood);
            house.setRoom(room);
            house.setBath(bath);
            house.setToilet(toilet);
            house.setBalcony(balcony);
            house.setAge(age);
            house.setIsDublex(isDublex);
            house.setIsFurnitured(isFurnitured);
            house.setHasAutoPark(hasAutopark);
            house.setHasChildPark(hasChildPark);
            house.setHasClimate(hasClimate);
            house.setHasPool(hasPool);

            return house; 
        }

        public HouseBuilder setCity(string city)
        {
            this.city=city;
            return this;
        }

        public HouseBuilder setTown(string town)
        {
            this.town=town;
            return this;
        }
        public HouseBuilder setNeighborhood(string neighborhood)
        {
            this.neighborhood=neighborhood;
            return this;
        }
        public HouseBuilder setRoom(int room)
        {
            this.room=room;
            return this;
        }
        public HouseBuilder setBath(int bath)
        {
            this.bath=bath;
            return this;
        }
        public HouseBuilder setToilet(int toilet)
        {
            this.toilet=toilet;
            return this;
        }
        public HouseBuilder setBalcony(int balcony)
        {
            this.balcony=balcony;
            return this;
        }
        public HouseBuilder setAge(int age)
        {
            this.age=age;
            return this;
        }
        public HouseBuilder setIsDublex(bool isDublex)
        {
            this.isDublex=isDublex;
            return this;
        }
        public HouseBuilder setIsFurnitured(bool isFurnitured)
        {
            this.isFurnitured=isFurnitured;
            return this;
        }
        public HouseBuilder setHasAutoPark(bool hasAutopark)
        {
            this.hasAutopark=hasAutopark;
            return this;
        }
        public HouseBuilder setHasChildPark(bool hasChildPark)
        {
            this.hasChildPark=hasChildPark;
            return this;
        }
        public HouseBuilder setHasClimate(bool hasClimate)
        {
            this.hasClimate=hasClimate;
            return this;
        }
        public HouseBuilder setHasPool(bool hasPool)
        {
            this.hasPool=hasPool;
            return this;
        }



        
        
    }
}