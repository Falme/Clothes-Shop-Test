public class OpenStoreInteractionEvent : InteractionEvent
{
	protected override void CallActionEvent()
	{
		UnityEditor.EditorApplication.isPaused = true;
	}
}
