using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour

{
    public float MoveSpeed;

    void Start()
    {

    }

    void Update()
    {
      if(Input.GetKey(KeyCode.W))
      {
      transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.S))
      {
      transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.A))
      {
      transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.D))
      {
      transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
      }
    }
}
