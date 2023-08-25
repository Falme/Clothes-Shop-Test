using TMPro;
using UnityEngine;

public class InteractableWarning : MonoBehaviour
{
	[SerializeField] private GameObject balloonIcon;

	private void Start() {
		DisableInteractionIcon();
	}

	public void EnableInteractionIcon()
	{
		balloonIcon.SetActive(true);
	}
	
	public void DisableInteractionIcon()
	{
		balloonIcon.SetActive(false);
	}
}
