using UnityEngine;

public class PeacetimeState : State
{
    public PeacetimeState(LevelStateMachine levelStateMachine) : base(levelStateMachine){}

    public override void Enter(GameObject[] stateObjects)
    {
        base.Enter(stateObjects);
        Debug.Log("EnteredPeace");
    }

    public override void Exit(GameObject[] stateObjects)
    {
        base.Exit(stateObjects);
        Debug.Log("ExitedPeace");
    }
}
