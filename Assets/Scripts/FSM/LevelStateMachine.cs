using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelStateMachine
{
    private Dictionary<Type, ILevelState> _states;
    private ILevelState _currentState;

    public LevelStateMachine()
    {
        _states = new Dictionary<Type, ILevelState>()
        {
            [typeof(PeacetimeState)] = new PeacetimeState(this),
            [typeof(BattleTimeState)] = new BattleTimeState(this)
        };
    }

    public void EnterIn<TState>(GameObject[] exitedStateObjects, GameObject[] enteredStateObjects) where TState : ILevelState
    {
        if(_states.TryGetValue(typeof(TState), out ILevelState state))
        {
            _currentState?.Exit(exitedStateObjects);
            _currentState = state;
            _currentState.Enter(enteredStateObjects);
        }
    }
}
