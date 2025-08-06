using System;

namespace ArchitectureTesting.Patterns.Bridge
{
    public class BeginnerLevels
    {
        protected readonly IPlayerClass playerClass;

        public BeginnerLevels( IPlayerClass playerClass)
        {
            this.playerClass = playerClass;
        }

        public bool Combat()
        {
            //class fights dragon 
            var dice = new Random(Seed: 6);
            var playerHitPoints = playerClass.GetHitPoints();
            var dragonHitPoints = 50;
            var dragonAC = 20;
            
            while (playerHitPoints > 0 && dragonHitPoints > 0)
            {
                var playerAttackRoll = playerClass.RollForAttack();
                if (playerAttackRoll > dragonAC)
                {
                    dragonHitPoints -= playerAttackRoll is 25 ? dice.Next(10) * 2 : dice.Next(10);
                }

                var dragonAttackRoll = dice.Next(20) + 8;
                if (dragonAttackRoll > playerClass.GetArmorClass())
                {
                    playerHitPoints -= dragonAttackRoll is 28 ? dice.Next(12) * 2 : dice.Next(12);
                }
            }

            return playerHitPoints > dragonHitPoints;
        }
    }
}
