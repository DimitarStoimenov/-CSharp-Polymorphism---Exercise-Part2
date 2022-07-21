using System;

namespace Raiding
{
    public static class Factory
    {

        public static BaseHero CreateHero(string name, string type)
        {
            if (type == "Druid")
            {
                int power = 80;
                return new Druid(name, power);
            }

            else if (type == "Paladin")
            {
                int power = 100;
                return new Paladin(name, power);
            }

            else if (type == "Rogue")
            {
                int power = 80;
                return new Rogue(name, power);
            }
            else if (type == "Warrior")
            {
                int power = 100;
                return new Warrior(name, power);
            }

            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            
        }
    }
}
