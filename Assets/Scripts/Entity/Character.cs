using System;
using UnityEngine;

public class Character : Actor
{ 
    // 기본 공격
    public BasicAttack BasicAttack { get; private set; }

    // IStat 구현
    public StatAbility StatAbility { get; set; }

    public override void Init(Transform transform = null)
    {
        base.Init(transform);

        // 스탯 관련 추가 ----------------------------------------------------------------------------------------
        StatAbility = new StatAbility();

        // 메인 스탯 추가
        var statData = GameApplication.Instance.GameModel.PresetData.ReturnData<StatData>(nameof(StatData), Id);
        StatAbility.AddStatData(StatAbility.StatInfo.StatDataType.Main, statData);

        StatAbility.CurrentSpeed = StatAbility.MaxSpeed;
        StatAbility.CurrentHp = StatAbility.MaxHp;
        StatAbility.CurrentBasicAttackRange = StatAbility.BasicAttackRange;
        // -------------------------------------------------------------------------------------------------------

        //  기본 공격 초기화
        BasicAttack = new BasicAttack(70001);
    }
}
