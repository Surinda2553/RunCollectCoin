using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float Fspeed;
    float FPositionX;
    float F1PositionX;

    void Start()
    {
        FPositionX = transform.position.x;
        F1PositionX = GameObject.Find ("Floor1").transform.position.x;
    }

   
    void Update()
    {
        transform.position = new Vector3 (transform.position.x + Fspeed, transform.position.y, transform.position.z);
    }
}
