using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public BoxCollider borderCollider;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 pos = other.transform.position;
            Vector3 borderPos = borderCollider.transform.position;
            Vector3 borderExtents = borderCollider.bounds.extents;

            if (pos.x < borderPos.x)
                pos.x = borderPos.x - borderExtents.x;
            if (pos.x > borderPos.x)
                pos.x = borderPos.x + borderExtents.x;
            if (pos.y < borderPos.y)
                pos.y = borderPos.y - borderExtents.y;
            if (pos.y > borderPos.y)
                pos.y = borderPos.y + borderExtents.y;

            other.transform.position = pos;
        }
    }
}
