using UnityEngine;

public class AxisPlayerInput : MonoBehaviour, IPlayerInput
{
	private const string HORIZONTAL = "Horizontal";
	private const string VERTICAL = "Vertical";

	public Vector2 GetInputAxis()
	{
		return new Vector2(Input.GetAxisRaw(HORIZONTAL), Input.GetAxisRaw(VERTICAL));
	}
}
