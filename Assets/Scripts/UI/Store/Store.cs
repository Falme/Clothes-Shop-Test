using System;
using UnityEngine;

public class Store : MonoBehaviour
{
	private Canvas canvas;

	private void Awake() {
		canvas = GetComponent<Canvas>();
	}

	private void OnEnable() {
		OpenStoreInteractionEvent.OnOpenStore += OpenStore;
	}


	private void OnDisable() {
		OpenStoreInteractionEvent.OnOpenStore -= OpenStore;
	}

	private void Update() {
		if(Input.GetKeyDown(KeyCode.Escape))
			CloseStore();
	}

	public void CloseStore()
	{
		PlayerAgency.hasPlayerAgency = true;
		canvas.enabled = false;
	}

	private void OpenStore()
	{
		canvas.enabled = true;
	}
}
