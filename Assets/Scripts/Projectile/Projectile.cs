using UnityEngine;

public class Projectile : Actor
{
    // IStat ����
    public StatAbility StatAbility { get; set; }

    public override void Init(Transform transform = null)
    {
        base.Init(transform);

        // ���� ���� �߰� ----------------------------------------------------------------------------------------
        StatAbility = new StatAbility();

        // ���� ���� �߰�
        var statData = GameApplication.Instance.GameModel.PresetData.ReturnData<StatData>(nameof(StatData), Id);
        StatAbility.AddStatData(StatAbility.StatInfo.StatDataType.Main, statData);

        StatAbility.CurrentSpeed = StatAbility.MaxSpeed;
        // -------------------------------------------------------------------------------------------------------
    }
}
