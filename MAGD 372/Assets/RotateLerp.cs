using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLerp : MonoBehaviour
{

    Vector3 relativePosition;
    Quaternion targetRotation;
    public Transform target;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        relativePosition = target.position - transform.position;
        targetRotation = Quaternion.LookRotation(relativePosition);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.time * speed);
    }
}
