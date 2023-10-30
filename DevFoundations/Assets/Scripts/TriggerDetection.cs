using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public GameObject characterToSpawn;
    public Transform spawnLocation;
    public TextMeshPro instantiatedText;
    public int instatiatedCounter = 1;
    public List<GameObject> platforms = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("ControllerCube"))
        {
           GameObject spawnedPrefab = Instantiate(characterToSpawn,spawnLocation.position,spawnLocation.rotation);
           spawnedPrefab.GetComponentInChildren<PrefabCollisionCount>().triggerCube = gameObject;
           ++instatiatedCounter;
           UpdateText();
            
            //spawnedPrefab.GetComponentInChildren<Rigidbody>().AddForce(Vector3.up*1000);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        int platformNumber = 0;
        foreach (GameObject platform in platforms)
        {
            platform.GetComponent<CollisionCounter>().textCounter.text = $"       {++platformNumber}             {platform.GetComponent<CollisionCounter>().collisionCount}          " +
                                                                         $"{((float)platform.GetComponent<CollisionCounter>().collisionCount/(float)instatiatedCounter):##0.#%}";
        }     
        instantiatedText.text = $"# Instantiated: {instatiatedCounter}";
    }
    
}
