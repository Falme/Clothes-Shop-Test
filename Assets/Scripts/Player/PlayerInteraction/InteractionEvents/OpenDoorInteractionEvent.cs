using UnityEngine;

public class OpenDoorInteractionEvent : InteractionEvent
{
	protected override void CallActionEvent()
	{
		#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
	}
}
