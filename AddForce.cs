using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
    public Rigidbody rb;
    public GameController gameController;
    public float force;

    void OnTriggerEnter(Collider other) {
        gameController.RemoveControl();
    }
    void OnTriggerStay(Collider other) {
        rb.AddForce(transform.up * force);
    }
}