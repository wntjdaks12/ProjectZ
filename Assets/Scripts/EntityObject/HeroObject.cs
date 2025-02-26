public class HeroObject : CharacterObject
{  
    // ����� ������
    public Hero Hero { get; private set; }

    public override void Init(Entity entity)
    {
        base.Init(entity);

        if (entity is Hero) Hero = entity as Hero;

        transform.gameObject.tag = "Hero";
    }
}
