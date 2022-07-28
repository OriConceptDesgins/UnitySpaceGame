using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    private LineRenderer lineRender;

    void Start()
    {
        lineRender = GetComponent<LineRenderer>();
    }


    void Update()
    {

        lineRender.SetPosition(0, transform.position);
        lineRender.SetPosition(1, transform.forward * 500);
    }
}
