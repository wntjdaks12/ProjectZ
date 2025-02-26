public class HeroObject : CharacterObject
{  
    // 히어로 데이터
    public Hero Hero { get; private set; }

    public override void Init(Entity entity)
    {
        base.Init(entity);

        if (entity is Hero) Hero = entity as Hero;

        transform.gameObject.tag = "Hero";
    }
}
