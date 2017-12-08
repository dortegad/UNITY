using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalController : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = rb.transform.position;
        position.z = position.z - 0.3f;

        if (position.z >= 0)
        {
            Quaternion rotation = rb.transform.rotation;
            rb.transform.SetPositionAndRotation(position, rotation);
        }
        else
            Destroy(gameObject);
	}
}
