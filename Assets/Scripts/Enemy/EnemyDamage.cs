using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    
    PlayerHealth playerHealth;
    public GameObject player;
    public int damage = 3;

    // Start is called before the first frame update
    void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
