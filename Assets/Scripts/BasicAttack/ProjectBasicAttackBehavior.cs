// 투사체 전략 기본 공격
public class ProjectBasicAttackBehavior : IBasicAttackBehavior
{
    private Projectile projectile;

    public BasicAttack BasicAttack { get; set; }

    public ProjectBasicAttackBehavior(BasicAttack basicAttack)
    {
        BasicAttack = basicAttack;

        //데이터 세팅
        projectile = GameApplication.Instance.GameModel.PresetData.ReturnData<Projectile>(nameof(Projectile), 20001);
    }

    public void Use(CharacterObject caster)
    {
        if (caster == null) return;

        var projObj = GameApplication.Instance.EntityController.Spawn<Projectile, ProjectileObject>(projectile.Id, caster.ProjectileNode.position, caster.transform.rotation);
        //projObj.Projectile.Caster = caster;
        //projObj.Projectile.Target = BasicAttack.BasicAttackInfo.TargetType;
    }
}
