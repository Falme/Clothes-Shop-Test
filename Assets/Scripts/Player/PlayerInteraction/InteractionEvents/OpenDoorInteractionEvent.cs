using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorInteractionEvent : MonoBehaviour, IInteractionEvent
{
	public void Action()
	{
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
