using UnityEngine;
using System.Collections;
   public class MouseLook : MonoBehaviour {
    public float xSpeed;
    public float ySpeed;

    void start()
    {
    }
    void update()
    {
        transform.eularAngles += new Vector3(0, Input.GetAxis("Mouse X") * xSpeed, 0);
        transform.eularAngles += new Vector3(0, Input.GetAxis("Mouse Y") * ySpeed, 0);
    }

}