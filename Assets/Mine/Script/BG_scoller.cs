using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_scoller : MonoBehaviour {

    public float scollSpeed;
    public int time;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update () {
        float newPosition = Mathf.Repeat(Time.time * scollSpeed, time);
        transform.position = startPosition + Vector3.forward * newPosition;
	}
}
