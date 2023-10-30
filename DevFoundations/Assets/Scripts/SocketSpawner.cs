using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketSpawner : MonoBehaviour
{
    public Transform socketTransform;
    public GameObject currentlyHeldPrefab;
    public List<GameObject> trackedObjects;
    public void SpawnPrefab(GameObject prefabToSpawn)
    {
        if (currentlyHeldPrefab != null)
        {
            Destroy(currentlyHeldPrefab);
        }

        currentlyHeldPrefab = Instantiate(prefabToSpawn,socketTransform.position,socketTransform.rotation);
        //currentlyHeldPrefab.GetComponent<Animator>().SetBool("Spawned",true);
    }

    public void DontDestroyThisObject(SelectExitEventArgs args)
    {
        if (args.interactableObject.transform.gameObject == currentlyHeldPrefab)
        {
            currentlyHeldPrefab = null;
        }
    }

    public void DoDestroyThisObject(SelectEnterEventArgs args)
    {
            currentlyHeldPrefab = args.interactableObject.transform.gameObject;
    }

    public void DestroyAllPrefabs()
    {
        foreach (GameObject prefab in trackedObjects)
        {
            Destroy(prefab);
        }
        trackedObjects.Clear();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        trackedObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
