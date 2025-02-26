public class BasicAttackInfo : Data
{
    public enum StrategyTypes
    {
        Melee, // 근접
        Ranged // 원거리
    }
    public StrategyTypes StrategyType { get; set; }

    public TargetTypes TargetType { get; set; }
}
