using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrefabCollisionCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] collisionCount = new int[6];
    public GameObject triggerCube;
    private bool collidedWithCharacter = false;
    private bool dealtWith = false;
    void Start()
    {
        for (int index = 0; index < collisionCount.Length; index++)
            collisionCount[index] = 1;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }
     private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.CompareTag("AmongUsKeegan"))
         {
             collidedWithCharacter = true;
             Debug.Log($"The characters collided!");
         }
             
         if (collision.gameObject.CompareTag("Ground"))
         {
             if (collidedWithCharacter && dealtWith == false) 
             {
                 int i = 0;
                 triggerCube.GetComponent<TriggerDetection>().instatiatedCounter--;
                 Debug.Log($"Removing instantiated {triggerCube.GetComponent<TriggerDetection>().instatiatedCounter}");
                 foreach (GameObject platform in triggerCube.GetComponent<TriggerDetection>().platforms)
                 {
                     if (collisionCount[i] == 0)
                     {
                         platform.GetComponent<CollisionCounter>().collisionCount--;
                     }
                     i++;
                 }
                 triggerCube.GetComponent<TriggerDetection>().UpdateText();
             }

             dealtWith = true;
             Destroy(gameObject); 
         }
    }
}
