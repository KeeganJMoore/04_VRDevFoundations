using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTime : MonoBehaviour
{
    // Start is called before the first frame update.
    public Transform followTransform;
    public FollowOnRail rail;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float between1and0 = Mathf.InverseLerp(rail.valueOutMin, rail.valueOutMax, rail.valueOut);
        float time = Mathf.Lerp(6, 22, between1and0);
        float hours = Mathf.Floor(time);
        float minutes = Mathf.Round(((time % 1) * 60) / 15)*15;
        if (minutes == 60)
        {
            hours = hours + 1;
            minutes = 0;
        }
        if (time < 12f)
        {
            gameObject.GetComponent<TextMeshPro>().text = $"Current Time: {hours:#0}:{minutes:00} am";
        }
        else if (Mathf.Floor(time) == 12)
        {
            gameObject.GetComponent<TextMeshPro>().text = $"Current Time: {hours:#0}:{minutes:00} pm";
        }
        else
        {
            hours = hours - 12;
            gameObject.GetComponent<TextMeshPro>().text = $"Current Time: {hours:#0}:{minutes:00} pm";
        }
        //Debug.Log();
        
        
    }
}
