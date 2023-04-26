using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 3.0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawn() 
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
