using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCharacter : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1,2,2);
    public Transform otherTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 startPosition = otherTransform.position;
        otherTransform.localScale = setScale;
        //otherTransform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
