using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    private Vector3 startingSize;
    public float activationSizeMultiplier = 10f;
    // Start is called before the first frame update
    void Start()
    {
        startingSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grow()
    {
        transform.localScale = startingSize * activationSizeMultiplier;
    }

    public void ReturnToOriginalSize()
    {
        transform.localScale = startingSize;
    }
}
