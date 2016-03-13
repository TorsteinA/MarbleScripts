using UnityEngine;
using System.Collections.Generic;

public class GravityScript : MonoBehaviour {
    public Rigidbody player;
    private Transform planet;

    private float pull;
    public float pullMax;

    void Start() {
        planet = GetComponent<Transform>();
        pull = 0;
    }


    void FixedUpdate() {
        player.AddForce((planet.transform.position - player.transform.position) * pull);
    }

    public void Pull() {
        pull = pullMax/2;
        Invoke("PullMax", 2);
       // yield WaitForSeconds(2.0);
    }

    public void PullMax() {
        pull = pullMax;
    }

}