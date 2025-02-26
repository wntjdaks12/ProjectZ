// 기본 공격 전략 행위
public interface IBasicAttackBehavior
{
    public BasicAttack BasicAttack { get; set; }

    public void Use(CharacterObject caster);
}
