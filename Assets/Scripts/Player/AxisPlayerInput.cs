using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisPlayerInput : MonoBehaviour, IPlayerInput
{
	public Vector2 GetInputAxis()
	{
		return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}
}
