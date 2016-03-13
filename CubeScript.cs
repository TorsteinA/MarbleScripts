using UnityEngine;
using System.Collections;
public class CubeScript : MonoBehaviour
{
    void Update()
    {
        var yRot = 5 * Input.GetAxis("Mouse X");
        transform.Rotate(0, yRot, 0);
    }
}