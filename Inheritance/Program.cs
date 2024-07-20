using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -Done
            // give this class 4 members that all Animals have in common -Done


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird()
            {
                Name = "Bigbird",
                Age = 5,
                Legs = 2,
                HasBackBone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,    
            };
            Console.WriteLine($"{bird1.Name} has {bird1.Legs} Legs, and is {bird1.Age} years old. It is {bird1.HasFeathers} he has feathers and {bird1.Wings} wings");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var reptile1 = new Reptile()
            {
                Name = "Reptar",
                Age = 45,
                Legs = 4,
                LivesNearWater = true,
                BirthEggs = true,
                Length = 1,
                LandSpeed = 10,

            };
        }
    }
}
