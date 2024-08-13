using UnityEngine;

public class BattleTimeState : State
{
    private readonly LevelStateMachine _levelStateMachine;

    public BattleTimeState(LevelStateMachine levelStateMachine)  :  base(levelStateMachine){}

    public override void Enter(GameObject[] stateObjects)
    {
        base.Enter(stateObjects);
        Debug.Log("EnteredBattle");
    }

    public override void Exit(GameObject[] stateObjects)
    {
        base.Exit(stateObjects);
        Debug.Log("ExitedBattle");
    }
}
