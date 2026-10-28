using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspScript : MonoBehaviour
{
    public Transform target;

    public float teleTimer = 3f;

    public GameObject teleEffect;

    private GameObject[] _teleSpots;

    private int _lastSpot = -1;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        _teleSpots = GameObject.FindGameObjectsWithTag("telespot");

        Instantiate(teleEffect, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        Vector3 difference = target.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ - 270f);

        teleTimer -= Time.deltaTime;

        if (teleTimer <= 0)
        {
            Tele();
            teleTimer = 3f;
        }
    }

    public void Tele()
    {
        if (_teleSpots.Length < 2) return;

        int randomSpot;

        // Choose a different teleport spot
        do
        {
            randomSpot = Random.Range(0, _teleSpots.Length);
        }
        while (randomSpot == _lastSpot);

        // Save current spot
        _lastSpot = randomSpot;

        // Teleport wasp
        transform.position = _teleSpots[randomSpot].transform.position;

        // Spawn teleport effect
        Instantiate(teleEffect, transform.position, transform.rotation);
    }
}
