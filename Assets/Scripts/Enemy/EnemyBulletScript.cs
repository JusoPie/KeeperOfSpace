using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{

    public float speed = 5f;

    PlayerHealth playerHealth;
    public int damage = 30;
    public GameObject explosion;

    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy (gameObject);
            playerHealth.TakeDamage(damage);
        }
    }
}
