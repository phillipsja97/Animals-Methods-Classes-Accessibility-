using Animals.Reptiles;
using System;


namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanAlligator = new Alligator(100);
            americanAlligator.IsAquatic = true;

            var africanAlligator = new Alligator(2);
            africanAlligator.IsAquatic = false;

            africanAlligator.Grunt();
            americanAlligator.Grunt();
            americanAlligator.Run(75);
            africanAlligator.Run(4);
            americanAlligator.Run(40);
            
            Console.ReadLine();
        
        }
    }
}
