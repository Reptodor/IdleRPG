using UnityEngine;

public interface ILevelState
{
    void Enter(GameObject[] stateObjects);
    void Exit(GameObject[] stateObjects);
}
