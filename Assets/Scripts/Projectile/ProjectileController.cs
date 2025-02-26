using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [field: SerializeField]
    public ProjectileObject ProjectileObject { get; private set; }

    private void Update()
    {
        ProjectileObject.OnMove(transform.forward, ProjectileObject.Projectile.StatAbility.CurrentSpeed);
    }

    public void OnTriggerEnter(Collider other)
    {/*
        // 투사체 타겟에 따른 처리
        switch (ProjectileObject.Projectile.Target)
        {
            case SkillInfo.TargetTypes.Self:

                if (other.transform.tag == "Player")
                {
                    ProjectileObject?.Projectile.OnRemoveData();
                }

                break;
            case SkillInfo.TargetTypes.Ally:

                if (other.transform.tag == "Player")
                {
                    ProjectileObject?.Projectile.OnRemoveData();
                }

                break;
            case SkillInfo.TargetTypes.Enemy:

                if (other.transform.tag == "Monster")
                {
                    ProjectileObject?.Projectile.OnRemoveData();
                }

                break;
            case SkillInfo.TargetTypes.Both:

                if (other.transform.tag == "Player" || other.transform.tag == "Monster")
                {
                    ProjectileObject?.Projectile.OnRemoveData();
                }

                break;
        }
        */

    }
}
