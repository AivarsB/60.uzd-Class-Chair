using System;
using System.Collections.Generic;
using System.Linq;

namespace _60.uzd_Class_Chair
{
    class Program
    {
        static void Main(string[] args)
        {
            var chairs = new List<Chair>
            {
                new Chair()
                {
                    height = 70,
                    color = "red",
                    material = "wood",
                    room = "living",
                },
                 new Chair()
                {
                    height = 80,
                    color = "green",
                    material = "plastic",
                    room = "living"
                },
                  new Chair()
                {
                    height = 80,
                    color = "grey",
                    material = "wood",
                    room = "kichen"
                },
                   new Chair()
                {
                    height = 120,
                    color = "white",
                    material = "metal",
                    room = "bar"
                },
                    new Chair()
                {
                    height = 120,
                    color = "green",
                    material = "metal",
                    room = "bar"
                },
                    new Chair()
                {
                    height = 65,
                    color = "yellow",
                    material = "plastic",
                    room = "balkony"
                }
            };

            // Izmantojot LINQ sameklēt tikai konkrētu objektu.

            var highestChair = chairs.Max(x => x.height);

            foreach (var chair in chairs)
            {
                if (chair.height == highestChair)
                {
                    Console.WriteLine($"Highest chair: {chair.AvailableChairs()}");
                }
            }

            foreach (var chair in chairs)
            {
                if (chair.color == "green")
                {
                    Console.WriteLine($"Green chair: {chair.AvailableChairs()}");
                }
            }

            foreach (var chair in chairs)
            {
                if (chair.material == "metal")
                {
                    Console.WriteLine($"Metal chair: {chair.AvailableChairs()}");
                }
            }

            foreach (var chair in chairs)
            {
                if (chair.room == "living")
                {
                    Console.WriteLine($"Living room chair: {chair.AvailableChairs()}");
                }
            }
        }
    }
}
// Izveidot klasi Chair, un pievienot tai atbilstošus properties (piemēram, augstums, krāsa utt.). 
// Pamatprogrammā uztaisīt vairākus šīs klases objektus. Pievienot visus šos objektus sarakstā. 
// Izmantojot LINQ sameklēt tikai konkrētu objektu.
