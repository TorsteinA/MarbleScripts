using UnityEngine;
using System.Collections;

public class CollectableSpin : MonoBehaviour {
    public float rotationSpeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, Time.deltaTime * rotationSpeed, 0f);
    }


}
