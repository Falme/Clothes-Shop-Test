using UnityEngine;

public class StandardInteractionInput : MonoBehaviour, IInteractionInput
{
	public bool GetInputDown()
	{
		return Input.GetKeyDown(KeyCode.E);
	}
}
