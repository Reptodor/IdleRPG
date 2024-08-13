using UnityEngine;

public class StateSwitch : MonoBehaviour
{
    [SerializeField] private GameObject[] _peacetimeStateObjects;
    [SerializeField] private GameObject[] _battleTimeStateObjects;

    private LevelStateMachine _levelStateMachine;

    private void Awake()
    {
        _levelStateMachine = new LevelStateMachine();
        _levelStateMachine.EnterIn<PeacetimeState>(null, _peacetimeStateObjects);
    }

    public void StartBattle()
    {
        _levelStateMachine.EnterIn<BattleTimeState>(_peacetimeStateObjects, _battleTimeStateObjects);
    }

    public void EndBattle()
    {
        _levelStateMachine.EnterIn<PeacetimeState>(_battleTimeStateObjects, _peacetimeStateObjects);
    }
}
