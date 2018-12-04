using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
	[SerializeField] NavMeshAgent[] agents;
	int index = 0;

	private void Start()
	{
		Debug.Log("AgentManager selected agent #" + index + " " + agents[index]);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{


			index++;

			if (index >= agents.Length)
			{
				index = 0;
			}

			// output status
			Debug.Log("AgentManager selected agent #" + index + " " + agents[index]);
		}


		// check for keypress and then Pause Agent
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			agents[index].GetComponent<NavAgentStateMachine_Best>().Pause();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			agents[index].GetComponent<NavAgentStateMachine_Best>().Reverse();
		}
	}
}
