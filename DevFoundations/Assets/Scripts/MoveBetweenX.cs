using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script moves the local x position of transform
/// between localPosition.x and localPosition.x + distance.
/// 
/// We'll use this script as an example of C# convention and syntax.
/// 
/// Tip: Becasue this script uses localPostion, if you give this transform 
/// a parent, you can rotate the parent to change direction we wag in.
/// </summary>

public class MoveBetweenX : MonoBehaviour
{
    public float distance = 3f;
    public float moveSpeed = 1f;

    Vector3 _direction;
    float _xMin;
    float _xMax;

    // Start is called before the first frame update
    private void Start()
    {
        _direction = Vector3.right;
        _xMin = transform.localPosition.x;
        _xMax = transform.localPosition.x + distance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = _direction * moveSpeed * Time.deltaTime;
        transform.localPosition += movement;

        SetDirection( transform.localPosition.x );
    }

    void SetDirection(float currentXPosition)
    {
        if (currentXPosition > _xMax)
        {
            _direction = Vector3.left;
        }
        else if (currentXPosition < _xMin)
        {
            _direction = Vector3.right;
        }
        /*
        else
        {
            //x is in between max and min
            //so direction is ok for now
        }
        */
    }
}
