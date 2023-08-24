using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
	private string currentInteraction = string.Empty;

	private void OnTriggerEnter2D(Collider2D other)
	{
		currentInteraction = other.name;
	}

	private void OnTriggerExit2D(Collider2D other) {
		currentInteraction = string.Empty;
	}

	private void Update() {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(currentInteraction.Equals("Door"))
			{
				UnityEditor.EditorApplication.isPlaying = false;
			} else if(currentInteraction.Equals("ShopKeeper"))
			{
				UnityEditor.EditorApplication.isPaused = true;
			} 
		}
	}
}
