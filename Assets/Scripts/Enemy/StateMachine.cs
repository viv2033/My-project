using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
    public PatrolState patrolState;

    private void Update()
    {
        if (activeState != null)
        {
            activeState.Perform();
        }
    }

    public void Initialize()
    {
        patrolState = new PatrolState();
        ChangeState(patrolState);
    }

    public void ChangeState(BaseState state)
    {
        if (activeState != null) 
        {
            activeState.Exit();
        }

        activeState = state;

        if (activeState != null)
        {
            activeState._stateMachine = this;
            activeState._enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}