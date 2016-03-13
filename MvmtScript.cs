using UnityEngine;
using System.Collections;

public class MvmtScript : MonoBehaviour {

	public float speed = 20;
	private Rigidbody rb;
	public GameObject camCube;
	public GameController gameController;

	void Start (){
		rb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate (){
		var controlDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		var actualDirection = camCube.transform.TransformDirection (controlDirection);
		rb.AddForce (actualDirection * speed);

	}


}


