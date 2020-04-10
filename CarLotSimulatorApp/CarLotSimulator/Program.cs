using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            Car secondCar = new Car();
            Car thirdCar = new Car();

            firstCar.Year = 1989;
            firstCar.Make = "Honda";
            firstCar.Model = "Prelude";
            firstCar.EngineNoise = " ";
            firstCar.HonkNoise = "honk";
            firstCar.IsDriveable = false;

            firstCar.MakeEngineNoise("budda budda budda");
            firstCar.MakeHonkNoise("honk");
            Console.WriteLine(firstCar);

            secondCar.Year = 1985;
            secondCar.Make = "Ford";
            secondCar.Model = "Escort";
            secondCar.EngineNoise = " ";
            secondCar.HonkNoise = "BEEP";
            secondCar.IsDriveable = false;

            secondCar.MakeEngineNoise("vroom");
            secondCar.MakeHonkNoise("BEEP");
            Console.WriteLine();

            thirdCar.Year = 2007;
            thirdCar.Make = "Volkswagen";
            thirdCar.Model = "Passat";
            thirdCar.EngineNoise = "vrrarararar";
            thirdCar.HonkNoise = "BRRMP";
            thirdCar.IsDriveable = false;

            thirdCar.MakeEngineNoise("vrrarararar");
            thirdCar.MakeHonkNoise("BRRMP");
            Console.WriteLine();
            Console.WriteLine("We're gonna need some better cars...");

            //TODO

            //DONE Create a separate class file called Car
            //DONE Car's following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property


            //DONE Now that the Car class is created we can instantiate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
