using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspScript : MonoBehaviour
{
    public Transform target;

    public float teleTimer = 3f;

    public GameObject teleEffect;

    //public GameObject teleSpot;
    //public GameObject teleSpot1;
    //public GameObject teleSpot2;
    //public GameObject teleSpot3;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Instantiate(teleEffect, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        Vector3 difference = target.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ - 270f);

        //*teleTimer -= Time.deltaTime;
        //if (teleTimer <= 0)
        //{
            //Tele();
            //teleTimer = 3f;
        //}
    }

    //public void Tele() 
    //{
        //transform.position = teleSpot.transform.position;
        //Instantiate(teleEffect, transform.position, transform.rotation);
    //}
}
