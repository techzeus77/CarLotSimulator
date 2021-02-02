using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Instantiation 1 or dot notation
            var AlvarosCar = new Car();
            AlvarosCar.Make = "Ford";
            AlvarosCar.Model = "Focus";
            AlvarosCar.Year = 2013;
            AlvarosCar.EngineNoise = "vroom";
            AlvarosCar.HonkNoise = "beep";
            AlvarosCar.IsDriveable = true;

            lot.Cars.Add(AlvarosCar);

            //Instantiation 2 or object initializer syntax
            var StevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = true,
            };

            //Add stevesCar to the CarLot
            lot.Cars.Add(StevesCar);

            //Instantiation 3 or using the constructor to allow to use the parameter values to be placed inside properties
            var BrettsCar = new Car(2015, "Honda", "Civic", "vrrooom", "vruuga", true);

            //Add BrettsCar to the CarLot
            lot.Cars.Add(BrettsCar);

            //Call methods
            //another way of making this work
            //AlvarosCar.MakeEngineNoise(AlvarosCar.EngineNoise);
            //stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            //BrettsCar.MakeEngineNoise(BrettsCar.EngineNoise);

            AlvarosCar.MakeEngineNoise();
            StevesCar.MakeEngineNoise();
            BrettsCar.MakeEngineNoise();



            //*************BONUS*************//

            //DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }



        }
    }
}
