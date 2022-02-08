using UnityEngine;

public class rotorx : MonoBehaviour
{

	public float speed = 20f;

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(speed * Time.deltaTime, 0f, 0f);
	}
}
