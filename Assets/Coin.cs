using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float Cspeed;
    float CPositionX;
    float C1PositionX;

    void Start()
    {
        CPositionX = transform.position.x;
        C1PositionX = GameObject.Find ("Coin").transform.position.x;
    }

   
    void Update()
    {
        transform.position = new Vector3 (transform.position.x + Cspeed, transform.position.y, transform.position.z);

    }
}