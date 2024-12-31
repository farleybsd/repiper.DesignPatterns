// See https://aka.ms/new-console-template for more information

using Design.Patterbs.Ripiper.Builder.GOOD;

var house = new House.Builder()
                            .setBathrooms(3)
                            .setBathrooms(2)
                            .setHasGarage(true)
                            .setHasGarage(true)
                            .Build();
 house.DisplayHouseInfo();                           