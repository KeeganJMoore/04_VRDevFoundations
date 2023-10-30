using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RaveCube : MonoBehaviour
{
    public bool checkBox;
    public float moveUpAmount = 0.5f;
    public MeshRenderer customCharacterFace;
    public Transform adventurerTransform;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (checkBox)
        {
            Debug.Log("Checked the box.");
            checkBox = false;
            ChangeColor();
            MoveUp(moveUpAmount);
        }
    }

    void ChangeColor()
    {
        Debug.Log("Changing color now.");
        customCharacterFace.material.color = GenerateRandomColor();
    }

    Color GenerateRandomColor()
    {
        return Random.ColorHSV();
    }

    
    void MoveUp(float amount)
    {
        adventurerTransform.position += Vector3.up*amount;
    }
    
}
