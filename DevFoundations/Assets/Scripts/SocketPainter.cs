using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketPainter : MonoBehaviour
{
    public GameObject socketedObject;
    public void RegisterObject(SelectEnterEventArgs args)
    {
        socketedObject = args.interactableObject.transform.gameObject;
    }

    public void ReleaseObject()
    {
        socketedObject = null;
    }

    public void ChangeMaterial(Material newMaterial)
    {
        if (socketedObject != null)
        {
            foreach (Transform child in socketedObject.GetComponentsInChildren<Transform>())
            {
                if (child.CompareTag("Body"))
                {
                    child.GetComponent<Renderer>().material = newMaterial;
                }
            }
        }
    }
}
