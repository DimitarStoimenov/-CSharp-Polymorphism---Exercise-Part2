using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
   public class StartUp 
    {

        public static void Main(string[] args)

        {
            List<BaseHero> heroes = new List<BaseHero>();
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            while (num != counter )
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                try
                {
                    var hero = Factory.CreateHero(heroName, heroType);
                    heroes.Add(hero);
                    counter++;
                    
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            int boss = int.Parse(Console.ReadLine());

            int sum = heroes.Sum(x => x.Power);
            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
            }
            if (sum >= boss)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }
        }

       
    }
}
