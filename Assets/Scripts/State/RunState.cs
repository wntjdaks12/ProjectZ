using UnityEngine;

public class RunState : IState
{
    public static RunState Instance { get; } = new RunState();
    public void OnBasicAttack(CharacterObject characterObject)
    {
        characterObject.animator.SetTrigger("OnAttack");
    }

    public void OnIdle(CharacterObject characterObject)
    {
        characterObject.animator.SetBool("IsRun", false);

        characterObject.StateManager.State = IdleState.Instance;
    }

    public void OnRun(CharacterObject characterObject)
    {
        var xAxis = Input.GetAxis("Horizontal");
        var zAxis = Input.GetAxis("Vertical");

        characterObject.animator.SetFloat("MoveX", xAxis);
        characterObject.animator.SetFloat("MoveZ", zAxis);
    }
}
