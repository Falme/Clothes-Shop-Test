using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardPlayerInput : MonoBehaviour, IPlayerInput
{
	public Vector2 GetInputAxis()
	{
		Vector2 axis = new Vector2();

		if(Input.GetKey(KeyCode.W)) axis.y = 1f;
		else if(Input.GetKey(KeyCode.S)) axis.y = -1f;
		
		if(Input.GetKey(KeyCode.A)) axis.x = -1f; 
		else if(Input.GetKey(KeyCode.D)) axis.x = 1f;

		return axis;
	}
}
