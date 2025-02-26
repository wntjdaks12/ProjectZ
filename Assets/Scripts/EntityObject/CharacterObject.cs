using UnityEngine;

public class CharacterObject : ActorObject
{
    // 캐릭터 데이터
    public Character Character { get; private set; }

    [field: SerializeField] 
    public Transform MiniHUDNode { get; private set; }
    [field: SerializeField]
    public Transform ProjectileNode { get; private set; }

    public StateManager StateManager { get; private set; }

    public override void Init(Entity entity)
    {
        base.Init(entity);

        if (entity is Character) Character = entity as Character;

        StateManager = new StateManager();
        StateManager.State.OnIdle(this);

        RegisterEvent();
    }

    public virtual void OnIde()
    {
        StateManager.State.OnIdle(this);
    }

    public virtual void OnRun(Vector3 dir, float speed)
    {
        transform.Translate(dir * Time.deltaTime * speed, Space.World);

        StateManager.State.OnRun(this);
    }

    public virtual void OnBasicAttack()
    {
        StateManager.State.OnBasicAttack(this);

        animationHandler.StartAttackAnimation();
    }

    public virtual void OnSkill()
    {
        StateManager.State.OnBasicAttack(this);

        //animationHandler.StartAttackAnimation();
    }

    private void RegisterEvent()
    {
        animationHandler.OnTriggerAttackEvent += () =>
        {
            Character.BasicAttack.Use(this);
        };
    }
}
