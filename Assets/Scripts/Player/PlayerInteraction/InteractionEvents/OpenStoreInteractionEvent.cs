using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStoreInteractionEvent : MonoBehaviour, IInteractionEvent
{
	public void Action()
	{
		UnityEditor.EditorApplication.isPaused = true;
	}
}
