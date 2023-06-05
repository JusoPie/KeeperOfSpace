using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float spawnInterval = 2.0f;

    [SerializeField]
    private float spawnDelay = 3f;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(spawnDelay);

        InvokeRepeating("spawn", 3.0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawn() 
    {
        if (gameObject.activeSelf) 
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
        else
        {
            CancelInvoke("spawn");
        }
    }

    public void respawn() 
    {
        if (!IsInvoking("spawn"))
        {
            InvokeRepeating("spawn", 3.0f, spawnInterval);
        }
    }
}
