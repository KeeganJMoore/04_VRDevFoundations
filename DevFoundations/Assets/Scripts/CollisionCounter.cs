using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro textCounter;
    public GameObject triggerCube;
    public int collisionCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        int platform = (int)char.GetNumericValue(textCounter.text[7]);
        if (collision.gameObject.GetComponent<PrefabCollisionCount>().collisionCount[platform-1] == 1)
        {
            collision.gameObject.GetComponent<PrefabCollisionCount>().collisionCount[platform - 1] = 0;
            ++collisionCount;
            triggerCube.GetComponent<TriggerDetection>().UpdateText();
        }
    }
}
