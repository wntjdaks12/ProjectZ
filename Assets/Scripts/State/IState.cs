public interface IState 
{
    public void OnIdle(CharacterObject characterObject);
    public void OnRun(CharacterObject characterObject);
    public void OnBasicAttack (CharacterObject characterObject);
}
