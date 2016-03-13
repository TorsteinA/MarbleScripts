using UnityEngine;
using System.Collections;

public class CameraZoomScript : MonoBehaviour {
	public float distance = 5f;
	public float distanceMin = 2f;
	public float distanceMax = 15f;

	public Transform cubeY;
	//	private Vector3 normDir;

	void Start (){
	}
	
	// Update is called once per frame
	void Update (){
		float distanceToTarget = Vector3.Distance (transform.position, cubeY.position);
		float inputDirection = Input.GetAxis ("Mouse ScrollWheel");

		if (inputDirection < 0 && distanceToTarget < distanceMax){
			transform.Translate (Vector3.forward * Input.GetAxis ("Mouse ScrollWheel"));
		} else if ((inputDirection > 0 && distanceToTarget > distanceMin)){
			transform.Translate (Vector3.forward * Input.GetAxis ("Mouse ScrollWheel"));
		}

	}



}
