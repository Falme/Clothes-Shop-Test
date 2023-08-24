using UnityEngine;

public class PlayerMagicCircle : MonoBehaviour
{
	[SerializeField] private float velocity;

    void Update() =>
    	transform.Rotate(Vector3.forward * velocity * Time.deltaTime);
}
