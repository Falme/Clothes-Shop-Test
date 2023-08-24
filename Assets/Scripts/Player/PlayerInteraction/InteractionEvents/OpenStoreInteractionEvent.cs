using UnityEngine;

public class OpenStoreInteractionEvent : MonoBehaviour, IInteractionEvent
{
	public void Action()
	{
		//UnityEditor.EditorApplication.isPaused = true;
		PlayerAgency.hasPlayerAgency = false;
	}
}
