using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXRotation : MonoBehaviour
{
    public FollowOnRail rail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion newRotation = Quaternion.Euler(rail.valueOut, -15,0);
        transform.rotation = newRotation;
    }
}
