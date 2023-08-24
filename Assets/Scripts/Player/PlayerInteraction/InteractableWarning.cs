using TMPro;
using UnityEngine;

public class InteractableWarning : MonoBehaviour
{
	[SerializeField] private SpriteRenderer balloonIcon;
	[SerializeField] private TextMeshPro balloonText;

	private void Start() {
		DisableInteractionIcon();
	}

	public void EnableInteractionIcon()
	{
		balloonIcon.enabled = balloonText.enabled = true;
	}
	
	public void DisableInteractionIcon()
	{
		balloonIcon.enabled = balloonText.enabled = false;
	}
}
