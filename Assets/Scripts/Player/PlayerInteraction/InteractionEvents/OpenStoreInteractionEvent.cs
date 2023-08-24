public class OpenStoreInteractionEvent : InteractionEvent
{
	public delegate void OpenStore();
	public static event OpenStore OnOpenStore;

	protected override void CallActionEvent()
	{
		OnOpenStore?.Invoke();
	}
}
