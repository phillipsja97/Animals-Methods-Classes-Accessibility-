using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    class Alligator
    {
        private int _stepGoal;
        private int _stepCount;
        public bool IsAquatic { get; set; }

        public Alligator(int stepGoal) //constructor method
        {
            IsAquatic = true;
            _stepGoal = stepGoal;

        }

        public void Grunt()
        {
            if (IsAquatic)
            {
                Console.WriteLine("bubble, bubble, bubble");
            } 
            else
            {
            Console.WriteLine("grrrrr!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran this many steps: {steps}");
            
            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("You're a step master");
            }
        }
    }
}
