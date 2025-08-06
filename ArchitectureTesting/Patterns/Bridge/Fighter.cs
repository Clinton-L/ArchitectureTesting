using System;

namespace ArchitectureTesting.Patterns.Bridge
{
    public class Fighter : IPlayerClass
    {
        public int GetArmorClass() => 18;

        public int GetHitPoints() => 20;

        public int GetSkillBonus() => 2;
        public int RollForAttack() => new Random(Seed: 10).Next(20) + 5;
    }
}
