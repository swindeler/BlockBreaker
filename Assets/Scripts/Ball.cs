using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;

	private bool hasStarted = false;
	private Vector3 paddletoBallVector;

	// Use this for initialization
	void Start () {
		paddletoBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddletoBallVector;

			if (Input.GetMouseButtonDown (0)) {
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
				hasStarted = true;
			}
		}
	}
}
