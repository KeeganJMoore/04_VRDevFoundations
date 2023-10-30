using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnim : MonoBehaviour
{
    public Animator anim;
    public string parameterName;
    public float startSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed(startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpeed(float setSpeed)
    {
        anim.SetFloat(parameterName,setSpeed);
    }
}
