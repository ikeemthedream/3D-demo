using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXandY;

    public float sensitivityHor = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            // horizontal rotation here
            Debug.Log("Horizontal");
            transform.Rotate(0, Input.GetAxis("Mouse X")* sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here
            Debug.Log("Vertical");
        }
        else
        {
            // both horizontal and vertical rotation here
            Debug.Log("Both");
        }
    }
}
