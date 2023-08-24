using UnityEngine;

public abstract class InteractionEvent : MonoBehaviour
{
	[SerializeField] private bool disablePlayer;

	public void Action()
	{
		CheckDisablePlayer();
		CallActionEvent();
	}

	private void CheckDisablePlayer()
	{
		if (disablePlayer)
			PlayerAgency.hasPlayerAgency = false;
	}

	protected virtual void CallActionEvent() { }
}
