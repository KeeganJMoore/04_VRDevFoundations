using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public static ObjectTracker Instance;
    public List<GameObject> trackedObjects = new List<GameObject>();
    public float totalDestructionTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(this);
        }
    }

    public void AddToTracked(GameObject objectToAdd)
    {
        trackedObjects.Add(objectToAdd);
    }
    
    public void DestroyAllPrefabs()
    {
       /* Debug.Log("Boom");
        foreach (GameObject prefab in trackedObjects)
        {
            Destroy(prefab);
        }
        trackedObjects.Clear();*/
       StartCoroutine(DestroyOverTime());
    }

    IEnumerator DestroyOverTime()
    {
        float timeBetween = totalDestructionTime / trackedObjects.Count;
        foreach (GameObject go in trackedObjects) // go is shorthand for gameobject
        {
            Destroy(go);
            yield return new WaitForSeconds(timeBetween);
        }
        trackedObjects.Clear();
    }
}
