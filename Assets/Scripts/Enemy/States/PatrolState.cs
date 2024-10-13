using UnityEngine;

public class PatrolState : BaseState
{
    public int waypointIndex;

    public override void Enter()
    {
        
    }

    public override void Perform()
    {
        PatrolCycle();
    }

    public override void Exit()
    {
        
    }

    public void PatrolCycle()
    {
        if (_enemy.Agent.remainingDistance < 0.2f)
        {
            if (waypointIndex < _enemy.path.waypoints.Count - 1)
            {
                waypointIndex++;
            } else
            {
                waypointIndex = 0;
            }
            Debug.Log(waypointIndex);
            _enemy.Agent.SetDestination(_enemy.path.waypoints[waypointIndex].position);
        }
    }
}
