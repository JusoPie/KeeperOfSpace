using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public Transform target;
    public Transform targetObject;
    public float enemySpeed = 1f;
    public float radius = 5f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        targetObject = GameObject.FindGameObjectWithTag("TankTarget").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        Vector3 difference = target.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90f);

        transform.Rotate(-90f, 0f, 0f, Space.Self);
        transform.RotateAround(targetObject.transform.position, new Vector3(0, 0, 10),enemySpeed * Time.deltaTime);
        // Calculate the desired position in a circle around the target point
        /*float angle = Time.time * enemySpeed;
        Vector3 desiredPosition = targetObject.position + new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * radius;

        // Move the object to the desired position
        transform.position = desiredPosition;*/




    }
}
