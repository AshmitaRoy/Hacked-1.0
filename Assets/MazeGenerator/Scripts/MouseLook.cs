using UnityEngine;
using System.Collections;
   public class MouseLook : MonoBehaviour {
    public float xSpeed;
    public float ySpeed;

    void Start()
    {
    }
    void Update()
    {
       
        transform.eulerAngles += new Vector3(0, Input.GetAxis("Mouse X") * xSpeed, 0);
        transform.eulerAngles += new Vector3(- Input.GetAxis("Mouse Y") * ySpeed, 0,0);
    }
}