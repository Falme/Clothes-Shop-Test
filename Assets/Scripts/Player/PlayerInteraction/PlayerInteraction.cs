using System;
using UnityEngine;

[RequireComponent(typeof(IInteractionInput))]
public class PlayerInteraction : MonoBehaviour
{
	[SerializeField] private InteractableWarning interactableWarning;

	private IInteractionEvent currentInteraction;
	private IInteractionInput interactionInput;

	private void Awake() {
		interactionInput = GetComponent<IInteractionInput>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		currentInteraction = other.GetComponent<IInteractionEvent>();
		interactableWarning.EnableInteractionIcon();
	}

	private void OnTriggerExit2D(Collider2D other) {
		currentInteraction = null;
		interactableWarning.DisableInteractionIcon();
	}
	
	private void Update()
	{
		if(PlayerAgency.hasPlayerAgency)
			UpdatePlayerInteraction();
	}

	private void UpdatePlayerInteraction()
	{
		if (interactionInput.GetInputDown() && currentInteraction != null)
			currentInteraction.Action();
	}
}
