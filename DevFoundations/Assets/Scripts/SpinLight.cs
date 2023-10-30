using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Random = UnityEngine.Random;
using Vector3 = System.Numerics.Vector3;

public class SpinLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.rotation = Quaternion.Euler(90,0,0);
        //transform.Rotate(0,0.25f*(float)Math.Sin(Time.timeAsDouble),0);
        transform.RotateAround(transform.position,UnityEngine.Vector3.up,360*Time.deltaTime);
        ;
    }
}

