using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterWait : MonoBehaviour
{
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitThenDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitThenDestroy()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
