using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int numberOfFrames = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Frame: {numberOfFrames}");
        numberOfFrames++;
    }
}

