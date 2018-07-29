using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public float tumble;
    public Rigidbody StoneRB;

	void Start () {
        StoneRB.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
