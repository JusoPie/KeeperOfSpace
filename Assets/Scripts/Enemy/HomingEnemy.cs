using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomingEnemy : MonoBehaviour
{
    
    public Transform target;
    public float enemySpeed = 1f;

    PlayerHealth playerHealth;
    //public GameObject player;
    public int damage = 30;

    public GameObject explosion;
    public CameraShake cameraShake;

    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);

        transform.Rotate(90f, 0f, 0f, Space.Self);
        transform.Rotate(0f, 90f, 0f, Space.Self);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            StartCoroutine(cameraShake.Shake(.15f, .4f));
            Destroy(gameObject);
            playerHealth.TakeDamage(damage);

            

        }
    }
}
