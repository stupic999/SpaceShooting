using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed;
    public Rigidbody Rb;

    void Start () {
        Rb.velocity = transform.forward * speed;
	}
}
