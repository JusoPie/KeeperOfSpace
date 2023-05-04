using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [Header("Player Movement")]
    [Range(0.1f, 30f)]
    public float playerSpeed = 10f;
    public float hor;
    public float ver;
    public float xRange;
    public float yRange;




    [Header("Shooting")]
    public Transform gun;
    public GameObject bullet;
    public float fireRate = 1.0f;
    private float nextFire = 0.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //This is for moving the player

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");


        transform.Translate(new Vector3(hor * playerSpeed * Time.deltaTime, ver * playerSpeed * Time.deltaTime, 0));

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        if (transform.position.y < -yRange + 1.9f)
        {
            transform.position = new Vector3(transform.position.x, -yRange + 1.9f, transform.position.z);
        }



        // This is for shooting

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Shoot();
        }
    }



    public void Shoot()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bullet, gun.transform.position, gun.transform.rotation);

    }
    
}