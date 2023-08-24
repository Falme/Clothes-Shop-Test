public class OpenDoorInteractionEvent : InteractionEvent
{
	protected override void CallActionEvent()
	{
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
