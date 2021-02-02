using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesServices
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine("Sevgili "+gamer.FirstName+", "+game.Name+" adlı oyun kütüphanene eklendi.);
        }
    }
}
