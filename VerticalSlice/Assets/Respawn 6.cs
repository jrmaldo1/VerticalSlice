using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn6 : MonoBehaviour
{
    public float threshold;


    void Start()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3((float)-143.5, (float)0.8900001, (float)-2.67);
        }
    }
}
