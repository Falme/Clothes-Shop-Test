using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
	[SerializeField] private InteractableWarning interactableWarning;

	private string currentInteraction = string.Empty;

	private void OnTriggerEnter2D(Collider2D other)
	{
		currentInteraction = other.name;
		interactableWarning.EnableInteractionIcon();
	}

	private void OnTriggerExit2D(Collider2D other) {
		currentInteraction = string.Empty;
		interactableWarning.DisableInteractionIcon();
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
