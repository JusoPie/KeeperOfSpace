using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScriptLeft : MonoBehaviour
{
    public Transform target;
    public Transform targetObject;
    public float enemySpeed = 1f;
    public float radius = 5f;


    [SerializeField]
    private float waitTime = 3f;

    public bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("StartOrbiting");
        target = GameObject.FindGameObjectWithTag("Player").transform;
        targetObject = GameObject.FindGameObjectWithTag("TankTarget").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == false)
        {

            transform.Translate(transform.right * -enemySpeed * Time.deltaTime);
            transform.LookAt(targetObject);
        }



        if (canMove == true)
        {
            //enemySpeed = 3f;
            transform.LookAt(target);

            Vector3 difference = target.position - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90f);

            transform.Rotate(-90f, 0f, 0f, Space.Self);
            transform.RotateAround(targetObject.transform.position, new Vector3(0, 0, 10), enemySpeed * Time.deltaTime);
        }




    }

    private IEnumerator StartOrbiting()
    {
        yield return new WaitForSeconds(waitTime);

        canMove = true;

    }
}