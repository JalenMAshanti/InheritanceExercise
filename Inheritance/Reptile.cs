using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool CanSwim { get; set; }

        public string ScaleColor { get; set; } 

        public bool LaysEggsOnLand { get; set; }

        public bool CanClimb { get; set; }

        public void ReptileDetails()
        {
            Console.WriteLine($" This Reptiles scales are a vibrant {ScaleColor}. " +
                $" most dont believe it but it is {CanClimb} that they can climb and {LaysEggsOnLand} that they lay legs on land. It is also {CanSwim} that they can swim." +
                $"They can be found in a {Enviornent}. traveling around on their {LegsAmount} legs.");

        }

    }
}
