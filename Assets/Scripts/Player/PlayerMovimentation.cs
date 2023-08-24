using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementation : MonoBehaviour
{
	[SerializeField] private float velocity;
	
	private Rigidbody2D rb2D;

	private IPlayerInput playerInput;

	private void Awake() 
	{
		rb2D = GetComponent<Rigidbody2D>();
		playerInput = GetComponent<IPlayerInput>();
	}

    private void Update() { }

	private void FixedUpdate()
	{
		MovePlayer(playerInput.GetInputAxis());
	}

	private void MovePlayer(Vector2 axis)
	{
		rb2D.velocity = axis * velocity * Time.fixedDeltaTime;
	}
}
