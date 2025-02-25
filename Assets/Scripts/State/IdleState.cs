using UnityEngine;

public class IdleState : IState
{
    public static IdleState Instance { get; } = new IdleState();

    public void OnBasicAttack(CharacterObject characterObject)
    {
        characterObject.animator.SetTrigger("OnAttack");
    }

    public void OnIdle(CharacterObject characterObject)
    {
    }

    public void OnRun(CharacterObject characterObject)
    {
        var xAxis = Input.GetAxis("Horizontal");
        var zAxis = Input.GetAxis("Vertical");

        characterObject.animator.SetFloat("MoveX", xAxis);
        characterObject.animator.SetFloat("MoveZ", zAxis);

        characterObject.animator.SetBool("IsRun", true);

        characterObject.StateManager.State = RunState.Instance;
    }
}
