using UnityEngine;
using System.Collections;

public class MagnetScript : MonoBehaviour
{

    public GameController gameController;

    //magnet values
    public float pull = 30;
    public float lossFactor = 1;
    public float blastForce;

    //objects
    public GameObject planet;
    public RotatorScript rotator;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        gameController.AddControl();
        rotator.RotateCube(transform.rotation);
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        var force = pull - (Vector3.Distance(planet.transform.position, rb.transform.position) * lossFactor);
        rb.AddForce(-planet.transform.up * force);
    }


    void OnTriggerExit(Collider other)
    {
        gameController.RemoveControl();
    }

    public void Push()
    {
        pull = blastForce * -pull;
    }

}