using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour {

	public float speed;
	public float distance;
	private float xStartPosition;

	void Start () {
		xStartPosition = transform.position.x;
	}
	void Update () {
		if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance))
		{
			speed *= -1;
			transform.localScale = new Vector3(-0.1274577f, 0.1274577f, 0.1274577f);

		}
		transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
	}
}
