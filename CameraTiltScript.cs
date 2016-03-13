using UnityEngine;
using System.Collections;

public class CameraTiltScript : MonoBehaviour {

	private float xRot;
	public float xRotMin = -90f;
	public float xRotMax = 0f;

	
	// Update is called once per frame
	void Update (){
		xRot += 2 * Input.GetAxis ("Mouse Y");
		xRot = Mathf.Clamp (xRot, xRotMin, xRotMax);
		transform.localEulerAngles = new Vector3 (-xRot, transform.localEulerAngles.y, transform.localEulerAngles.z);
	
	}
}
