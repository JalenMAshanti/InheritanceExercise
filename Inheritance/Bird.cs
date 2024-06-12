using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string FeatherColor { get; set; }

        public bool CanFly { get; set; }

        public string BirdSound { get; set; }

        public bool EatsSeeds {get; set;}



        public void BirdDetails()
        {
            Console.WriteLine($" This birds feather color is a beautiful {FeatherColor}. " +
                $"you can often tell them apart by their distinct {BirdSound} they make. it is {EatsSeeds} that they eat seed and {CanFly} that" +
                $" they can fly. They can be found in a {Enviornent} hopping around on their {LegsAmount} legs");

        }
    }

}
