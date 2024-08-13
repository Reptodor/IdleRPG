using UnityEngine;

public abstract class State : ILevelState
{
    private readonly LevelStateMachine _levelStateMachine;

    public State(LevelStateMachine levelStateMachine)
    {
        _levelStateMachine = levelStateMachine;
    }

    public virtual void Enter(GameObject[] stateObjects)
    {
        foreach (var stateObject in stateObjects)
        {
            stateObject.gameObject.SetActive(true);
        }
    }

    public virtual void Exit(GameObject[] stateObjects)
    {
        foreach (var stateObject in stateObjects)
        {
            stateObject.gameObject.SetActive(false);
        }
    }
}
