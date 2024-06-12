using System;
using System.Collections.Generic;

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



            Bird robin = new Bird();
            robin.CanFly = true;
            robin.HasClaws = false;
            robin.FeatherColor = "Red & Black";
            robin.Enviornent = "Fields";
            robin.EatsSeeds = true;
            robin.LegsAmount = 2;
            robin.BirdSound = "tweet tweet"; 
            robin.IsWarmBlooded = true;



            Reptile snake = new Reptile();
            snake.CanClimb = true;
            snake.HasClaws = false;
            snake.Enviornent = "Grass Lands or Deserts";
            snake.CanSwim = false;
            snake.HasClaws = false;
            snake.ScaleColor = "Green";
            snake.LegsAmount = 0;
            snake.LaysEggsOnLand = true;


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

                robin.BirdDetails();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             * 
             *
             */

            snake.ReptileDetails();



        }
    }
}
