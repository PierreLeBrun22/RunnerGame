using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVelocity : MonoBehaviour
{
    public Vector3 v3Force;
    [SerializeField]KeyCode keyPositive;
    [SerializeField] KeyCode keyNegative;

    public Vector3 lastCheckPointPosition;
    public Vector3 lastSpeedRegister;

    void FixedUpdate ()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
