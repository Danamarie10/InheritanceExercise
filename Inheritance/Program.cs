using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


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
            var bigBird = new Bird();
            bigBird.Legs = 2;
            bigBird.Age = 15;
            bigBird.Sound = "Chirp";
            bigBird.Color = "Yellow";
            bigBird.canFly = true;
            bigBird.hasBeak = true;
            bigBird.feathers = true;
            bigBird.hasWings = true;

            Console.WriteLine($"BigBird has {bigBird.Legs} legs and it is {bigBird.canFly} he can fly. With his lovely {bigBird.Color} color and {bigBird.Age} years of age it is amazing he is still able to {bigBird.Sound}.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var kermit = new Reptile();
            kermit.Legs = 2;
            kermit.Age = 68;
            kermit.Sound = "Iconic";
            kermit.Color = "Green";
            kermit.hasScales = false;
            kermit.isColdBlooded = true;
            kermit.canHaveLiveBabies = false;
            kermit.isDry = false;

            Console.WriteLine($"Kermit is a whooping {kermit.Age} years old and rocks his historic {kermit.Color} color. He has {kermit.Legs} legs so he can ride his bike, and his {kermit.Sound} voice has impacted children for ages. It is {kermit.hasScales} that Kermit has scales as well as it being {kermit.isColdBlooded} that he is cold blooded both being due to him being a puppet.I imagine it is also {kermit.canHaveLiveBabies} that Kermit can have live babies being that he is with a pig.");

        }
    }
}
