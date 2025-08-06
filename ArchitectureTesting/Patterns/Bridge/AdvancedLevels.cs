using System;

namespace ArchitectureTesting.Patterns.Bridge
{
    public class AdvancedLevels : BeginnerLevels
    {
        public AdvancedLevels(IPlayerClass playerClass) : base(playerClass)
        {
        }

        public bool SkillCheck(int dc)
        {
            var dice = new Random();
            return dice.Next(20) + playerClass.GetSkillBonus() > dc;
        }
    }
}
