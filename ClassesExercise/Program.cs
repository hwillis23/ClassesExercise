using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            var myCar = new Car(); //new instance of the car class with a new object 

            myCar.Year = 2022;
            myCar.Model = "Stingray";
            myCar.Make = "Corevette";
            
            

           Console.WriteLine($"I just bought a black {myCar.Year} {myCar.Model} {myCar.Make}.");



           


        }
    }
}
