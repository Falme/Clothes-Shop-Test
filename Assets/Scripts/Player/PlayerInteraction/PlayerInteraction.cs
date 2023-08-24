using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
	[SerializeField] private InteractableWarning interactableWarning;

	private IInteractionEvent currentInteraction;

	private void OnTriggerEnter2D(Collider2D other)
	{
		currentInteraction = other.GetComponent<IInteractionEvent>();
		interactableWarning.EnableInteractionIcon();
	}

	private void OnTriggerExit2D(Collider2D other) {
		currentInteraction = null;
		interactableWarning.DisableInteractionIcon();
	}

	private void Update() {
		if(Input.GetKeyDown(KeyCode.E) && currentInteraction != null)
			currentInteraction.Action();
	}
}
