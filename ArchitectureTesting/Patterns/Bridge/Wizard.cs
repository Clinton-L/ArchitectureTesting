using System;

namespace ArchitectureTesting.Patterns.Bridge
{
    public class Wizard : IPlayerClass
    {
        public int GetArmorClass() => 12;

        public int GetHitPoints() => 15;
        public int GetSkillBonus() => 6;

        public int RollForAttack() => new Random(10).Next(20) + 5;
    }
}
