using System.Collections.Generic;
using System.Linq;

// 스탯 능력치
public class StatAbility
{
    public class StatInfo
    {
        public enum StatDataType { Main }

        public StatDataType statDataType;
        public StatData statData;

        public StatInfo(StatDataType statType, StatData statData)
        {
            this.statDataType = statType;
            this.statData = statData;
        }
    }

    private List<StatInfo> statInfos;

    public StatAbility()
    {
        statInfos = new List<StatInfo>();
    }

    /// <summary>
    /// 스탯 데이터 추가
    /// </summary>
    /// <param name="statDataType">스탯 데이터 타입</param>
    /// <param name="statData">스탯 데이터</param>
    public void AddStatData(StatInfo.StatDataType statDataType, StatData statData)
    {
        statInfos.Add(new StatInfo(statDataType, statData));
    }

    /// <summary>
    /// 스텟 데이터 삭제
    /// </summary>
    /// <param name="statDataType">스탯 데이터 타입</param>
    /// <param name="statData">스탯 데이터</param>
    public void RemoveStatData(StatInfo.StatDataType statDataType , StatData statData)
    {
        var statInfo = statInfos.Where(x => x.statDataType == statDataType && x.statData == statData).FirstOrDefault();

        if (statInfo == null)
        {
        }
        else 
        {
            statInfos.Remove(statInfo);
        }
    }

    // 현재 이동 속도
    private float currentSpeed;
    public float CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }
    // 현재 체력
    private int currentHp;
    public int CurrentHp
    {
        get { return currentHp; }
        set { currentHp = value; }
    }
    // 현재 기본 공격 사거리
    private float currentBasicAttackRange;
    public float CurrentBasicAttackRange
    {
        get { return currentBasicAttackRange; }
        set { currentBasicAttackRange = value; }
    }

    // 최대 이동 속도
    public float MaxSpeed
    {
        get { return statInfos.Sum(x => x.statData.GetTotalStatValue(Stat.StatTypes.MaxSpeed)); }
    }
    // 최대 체력
    public int MaxHp
    {
        get { return (int)statInfos.Sum(x => x.statData.GetTotalStatValue(Stat.StatTypes.MaxHp)); }
    }
    // 가시 거리
    public float VisableDistance
    {
        get { return statInfos.Sum(x => x.statData.GetTotalStatValue(Stat.StatTypes.VisableDistance)); }
    }
    // 시야 각
    public float ViewingAngle
    {
        get { return statInfos.Sum(x => x.statData.GetTotalStatValue(Stat.StatTypes.ViewingAngle)); }
    }
    // 기본 공격 사거리
    public float BasicAttackRange
    {
        get { return statInfos.Sum(x => x.statData.GetTotalStatValue(Stat.StatTypes.BasicAttackRange)); }
    }
}
