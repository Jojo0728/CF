
using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEditor;
using UnityEngine.SceneManagement;


public class NavAgentStateMachine_Best : FSGDN.StateMachine.MachineBehaviour
{
    [SerializeField] NavPoint[] myNavPoints;
    int navIndex = 0;

    public void Awake()
    {
        myNavPoints[0] = FindObjectOfType<NavPoint>();
    }

    public override void Start()
	{
		base.Start();
	}

	public override void AddStates()
    {
        AddState<PatrolState_Best>();
        AddState<IdleState_Best>();
        AddState<PauseState>();


        SetInitialState<PatrolState_Best>();
    }

	bool reversed = false;

    public void pickNextNavPoint()
    {
		if (!reversed)
		{
			++navIndex;
			if (navIndex >= myNavPoints.Length)
				navIndex = 0;
		}
		else
		{
			--navIndex;
			if (navIndex < 0)
				navIndex = myNavPoints.Length - 1;
		}
    }

    public void FindDestination()
    {
		if (myNavPoints.Length > 0)
		{
			GetComponent<NavMeshAgent>().SetDestination(myNavPoints[navIndex].transform.position);
            GetComponent<NavMeshAgent>().speed = Random.Range(0.5f, 3f);
		}
    }

	public void Reverse()
	{
		reversed = !reversed;

		if (reversed)
		{
			if (navIndex - 1 < 0)
			{
				navIndex = myNavPoints.Length - 1;
			}
			else
			{
				navIndex--;
			}
			GetComponent<NavMeshAgent>().SetDestination(myNavPoints[navIndex].transform.position);
		}
		else
		{
			if (navIndex + 1 > myNavPoints.Length - 1)
			{
				navIndex = 0;
			}
			else
			{
				navIndex++;
			}
			GetComponent<NavMeshAgent>().SetDestination(myNavPoints[navIndex].transform.position);
		}
	}

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<NavPoint>())
        {
            ChangeState<IdleState_Best>();
        }
        else if (other.gameObject.GetComponent<Portal>())
        {
            SceneManager.LoadScene("GAMEOVER");
        }
        else if (other.gameObject.GetComponent<Bullet>())
        {
            Destroy(gameObject);
        }
    }
    bool paused = false;
    FSGDN.StateMachine.State lastState = null;

    public void Pause()
    {
        paused = !paused;

        if (paused)
        {
            // store current state for use when unpausing
            lastState = currentState;

            // change state to Pause
            ChangeState<PauseState>();
            GetComponent<NavMeshAgent>().isStopped = true;
		}
        else
        {
            ChangeState(lastState.GetType());
            GetComponent<NavMeshAgent>().isStopped = false;
		}
    }
    public override void Update()
    {
        base.Update();
	}
}

public class NavAgentState : FSGDN.StateMachine.State
{
    // Nice accessor for getting our state machine script reference
    protected NavAgentStateMachine_Best NavAgentStateMachine()
    {
        return ((NavAgentStateMachine_Best)machine);
    }
}

// NOTE: now inherits from NavAgentState
public class PatrolState_Best : NavAgentState
{
    public override void Enter()
    {
        base.Enter();
        NavAgentStateMachine().FindDestination();
    }
}
public class IdleState_Best : NavAgentState
{
    float timer = 0;

    public override void Enter()
    {
        base.Enter();
        timer = 0;
    }

    public override void Execute()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            machine.ChangeState<PatrolState_Best>();
            NavAgentStateMachine().pickNextNavPoint();
        }
    }
}

public class PauseState : NavAgentState
{
    public override void Enter()
    {
        base.Enter();
    }
}
