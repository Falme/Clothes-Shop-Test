using UnityEngine;

public class OpenStoreInteractionEvent : InteractionEvent
{
	[SerializeField] private Canvas canvas;

	protected override void CallActionEvent()
	{
		canvas.enabled = true;
	}
}
