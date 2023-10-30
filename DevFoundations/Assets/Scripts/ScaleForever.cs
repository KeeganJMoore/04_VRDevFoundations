using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleForever : MonoBehaviour
{
    private Vector3 setScale = new Vector3(1,1,1);
    public Transform otherTransform;
    private bool grow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (grow)
        {
            transform.localScale += setScale * Time.deltaTime;
            if (transform.localScale.x >= 25)
            {
                grow = false;
            }
        }
        else
        {
            transform.localScale -= setScale * Time.deltaTime;
            if (transform.localScale.x <= 1)
            {
                grow = true;
            }
        }
    }
}
