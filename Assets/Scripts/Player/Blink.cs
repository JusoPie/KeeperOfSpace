using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public float blinkDistance = 2.0f;

    public int blinks = 3;

    public float blinktimer = 5f;

    public GameObject[] blinkImages;

    public GameObject blinkEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blinks == 3)
        {
            blinkImages[2].SetActive(true);
            blinkImages[1].SetActive(true);
            blinkImages[0].SetActive(true);
        }
        if (blinks == 2)
        {
            blinkImages[2].SetActive(false);
            blinkImages[1].SetActive(true);
            blinkImages[0].SetActive(true);
        }
        if (blinks == 1)
        {
            blinkImages[2].SetActive(false);
            blinkImages[1].SetActive(false);
            blinkImages[0].SetActive(true);
        }
        if (blinks == 0)
        {
            blinkImages[2].SetActive(false);
            blinkImages[1].SetActive(false);
            blinkImages[0].SetActive(false);
        }
        if (blinks != 3) 
        {
            blinktimer -= Time.deltaTime;
            if (blinktimer <= 0) 
            {
                blinks++;
                blinktimer = 5f;
            }
        }

        if (blinks > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Vector3 blinkDirection = Vector3.zero;

                if (Input.GetKey(KeyCode.W))
                {
                    blinkDirection += Vector3.up;
                    blinks--;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    blinkDirection += Vector3.down;
                    blinks--;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    blinkDirection += Vector3.left;
                    blinks--;
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    blinkDirection += Vector3.right;
                    blinks--;
                }

                if (blinkDirection != Vector3.zero)
                {
                    Vector3 blinkDestination = transform.position + blinkDirection.normalized * blinkDistance;
                    transform.position = blinkDestination;

                    Instantiate(blinkEffect, transform.position, transform.rotation);

                }

            }
        }
    }
}
