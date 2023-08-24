using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementation : MonoBehaviour
{
	[SerializeField] private float velocity;
	
	private Rigidbody2D rb2D;

	private Vector2 axis;

	private void Awake() 
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
		axis = Vector2.zero;

		if(Input.GetKey(KeyCode.W)) axis.y = 1f;
		else if(Input.GetKey(KeyCode.S)) axis.y = -1f;
		
		if(Input.GetKey(KeyCode.A)) axis.x = -1f; 
		else if(Input.GetKey(KeyCode.D)) axis.x = 1f; 
    }

	private void FixedUpdate()
	{
		MovePlayer();
	}

	private void MovePlayer()
	{
		rb2D.velocity = axis * velocity * Time.fixedDeltaTime;
	}
}
