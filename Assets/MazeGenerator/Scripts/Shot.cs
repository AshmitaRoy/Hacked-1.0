using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{

    public float ShotSpeed;
    public float TimeToDestroy;

    void Start()
    {
        TimeToDestroy = 5;
    }

    void Update()
    {
        TimeToDestroy -= Time.deltaTime;
        transform.Translate(Vector3.forward * ShotSpeed * Time.deltaTime);
        if (TimeToDestroy <= 0)
        {
            Destroy(gameObject);
        }


    }
}
