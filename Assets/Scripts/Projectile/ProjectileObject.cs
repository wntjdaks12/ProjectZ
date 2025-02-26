using UnityEngine;

public class ProjectileObject : ActorObject
{ 
    // 투사체 데이터
    public Projectile Projectile { get; private set; }

    public override void Init(Entity entity)
    {
        base.Init(entity);

        if (entity is Projectile) Projectile = entity as Projectile;
    }

    public virtual void OnMove(Vector3 dir, float speed)
    {
        transform.Translate(dir * Time.deltaTime * speed, Space.World);
    }
}
