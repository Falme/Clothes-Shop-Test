using UnityEngine;

public class Store : MonoBehaviour
{
	private Canvas canvas;

	private void Awake() {
		canvas = GetComponent<Canvas>();
	}

	private void Update() {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			PlayerAgency.hasPlayerAgency = true;
			canvas.enabled = false;
		}
	}
}
