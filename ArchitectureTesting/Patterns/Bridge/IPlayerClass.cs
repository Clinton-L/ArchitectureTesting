namespace ArchitectureTesting.Patterns.Bridge
{
    public interface IPlayerClass
    {
        int GetHitPoints();
        int GetArmorClass();
        int GetSkillBonus();
        int RollForAttack();
    }
}
