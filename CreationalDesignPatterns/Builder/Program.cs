using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
           House house1 = HouseBuilder.startBuild()
                                    .setCity("Ankara")
                                    .setTown("Etimesgut")
                                    .setNeighborhood("Eryaman")
                                    .setRoom(3)
                                    .setBath(2)
                                    .setToilet(2)
                                    .setBalcony(1)
                                    .setIsDublex(false)
                                    .setIsFurnitured(true)
                                    .setHasAutoPark(true)
                                    .setHasChildPark(true)
                                    .setHasClimate(false)
                                    .setHasPool(false)
                                    .setAge(2006)
                                    .build();

            EstateAgentWithBuilder.printHouse(house1);
        }
    }
}
