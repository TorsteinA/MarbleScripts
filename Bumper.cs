using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

    public float thrust = 1;
    public AudioSource bumperSound;

    void OnCollisionEnter(Collision other) {
        var rb = other.collider.GetComponent<Rigidbody>();
        rb.AddForce(transform.position - other.transform.position * thrust);
        bumperSound.Play();
    }
}