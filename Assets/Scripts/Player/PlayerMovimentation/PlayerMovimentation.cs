using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{
	[SerializeField] private float velocity;

	private Animator animator;
	
	private Rigidbody2D rb2D;

	private IPlayerInput playerInput;

	private void Awake() 
	{
		rb2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		playerInput = GetComponent<IPlayerInput>();
	}


	private void FixedUpdate()
	{
		MovePlayer(playerInput.GetInputAxis());
	}

	private void MovePlayer(Vector2 axis)
	{
		rb2D.velocity = axis * velocity * Time.fixedDeltaTime;
		UpdateSprite(axis);
	}

	private void UpdateSprite(Vector2 axis)
	{
		animator.SetFloat("Horizontal", axis.x);
		animator.SetFloat("Vertical", axis.y);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name);
	}
}
