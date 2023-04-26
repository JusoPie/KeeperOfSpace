using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public float blinkDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Vector3 blinkDirection = Vector3.zero;

            if (Input.GetKeyDown(KeyCode.W))
            {
                blinkDirection += Vector3.up;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                blinkDirection += Vector3.down;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                blinkDirection += Vector3.left;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                blinkDirection += Vector3.right;
            }

            if (blinkDirection != Vector3.zero)
            {
                Vector3 blinkDestination = transform.position + blinkDirection.normalized * blinkDistance;
                transform.position = blinkDestination;
            }
        }
    }
}
