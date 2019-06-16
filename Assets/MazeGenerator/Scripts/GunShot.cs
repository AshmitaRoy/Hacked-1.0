using UnityEngine;
using System.Collections;

public class GunShot : MonoBehaviour
{
    public GameObject Shot;
    public GameObject ShotSpawn;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Shot, ShotSpawn.transform.position, ShotSpawn.transform.rotation);
        }

    }
}
