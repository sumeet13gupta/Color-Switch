using UnityEngine;

public class rotory : MonoBehaviour
{

	public float speed = 20f;

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0f, speed * Time.deltaTime, 0f);
	}
}
