using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key pressed");
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key pressed");
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S key pressed");
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key pressed");
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key pressed");
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("shift key pressed");
            transform.position += Vector3.down;
        }
    }
}
