using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject : MonoBehaviour
{
    //public ObjectTracker tracker;
    // Start is called before the first frame update
    public GameObject destroyFX;
    void Start()
    {
        ObjectTracker.Instance.AddToTracked(gameObject);
    }

    private void OnDestroy()
    {
        if (gameObject.scene.isLoaded) // Without this we get errors on game end
        {
            GameObject particleEffect = Instantiate(destroyFX, transform.position, transform.rotation);
            if (transform.CompareTag("AmongUsKeegan"))
            {
                foreach (Transform child in transform.GetComponentsInChildren<Transform>())
                {
                    if (child.CompareTag("Body"))
                    {
                        particleEffect.GetComponent<Renderer>().material = child.GetComponent<Renderer>().material;
                        break;
                    }
                }
            }
            else
            {
                particleEffect.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;                
            }
                        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
