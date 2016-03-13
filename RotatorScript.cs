using UnityEngine;
using System.Collections;

public class RotatorScript : MonoBehaviour
{

    public Transform target;
    private bool rotating;
    public Quaternion targetRot;
    //public Quaternion myRot;

    public float flipSpeed = 1f;

    // Use this for initialization
    void Start()
    {
        rotating = false;

    }

    void Update()
    {
        transform.position = target.position;

        if (rotating)
        {
            Flip();
            if (transform.rotation == targetRot)
            {
                rotating = false;
            }
        }

    }

    //Sets the new target rotation of the cube
    public void RotateCube(Quaternion targetRot)
    {
        this.targetRot = targetRot;
        rotating = true;
    }

    //Flips the cube to targetRot
    public void Flip()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.deltaTime * flipSpeed);
    }

}