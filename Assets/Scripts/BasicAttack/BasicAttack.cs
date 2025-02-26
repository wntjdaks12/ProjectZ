public class BasicAttack
{
    public int Id { get; private set; }

    public BasicAttackInfo BasicAttackInfo { get; private set; } // 기본 공격 정보

    private IBasicAttackBehavior basicAttackBehavior; // 기본 공격 전략 행위

    public BasicAttack(int id)
    {
        Id = id;

        BasicAttackInfo = GameApplication.Instance.GameModel.PresetData.ReturnData<BasicAttackInfo>(nameof(BasicAttackInfo), id);

        switch (BasicAttackInfo.StrategyType)
        {
            case BasicAttackInfo.StrategyTypes.Ranged: SetBasicAttackBehavior(new ProjectBasicAttackBehavior(this)); break;
        }
    }

    // 기본 공격 전략 행위 세팅
    public void SetBasicAttackBehavior(IBasicAttackBehavior basicAttackBehavior)
    {
        this.basicAttackBehavior = basicAttackBehavior;
    }

    // 기본 공격 사용
    public void Use(CharacterObject caster)
    {
        if (caster != null) basicAttackBehavior.Use(caster);
    }
}
