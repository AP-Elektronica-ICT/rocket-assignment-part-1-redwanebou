using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // default waardes //
    [SerializeField] float up = 1000f;
    [SerializeField] float leftright = 50f;
    Rigidbody rigi;
    bool upkey;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        upkey = Input.GetKey(KeyCode.Space);
        float tilt = Input.GetAxis("Horizontal");

        if (!Mathf.Approximately(tilt, 0f))
        {
            rigi.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tilt * leftright * Time.deltaTime))));
        }
        // terug resetten //
        rigi.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if (upkey)
        {
            rigi.AddRelativeForce(Vector3.up * up * Time.deltaTime);
        }
    }
}
