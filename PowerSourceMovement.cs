using UnityEngine;
using System.Collections;

public class PowerSourceMovement : MonoBehaviour {

    public int maxSpeed;

    private Vector3 startPosition;

    // Use this for initialization
    void Start() {
        maxSpeed = 3;

        startPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update() {
        MoveVertical();
    }

    void MoveVertical() {
        transform.localPosition = new Vector3(transform.localPosition.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.localPosition.z);

        if (transform.localPosition.y > 0.4f) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        }
        else if (transform.localPosition.y < -0.4f) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        }
    }
}