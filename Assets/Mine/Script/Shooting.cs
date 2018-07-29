using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject Bullet;
    public Transform PlayerShot;
    public float FireTime = 0.2f;
	
	void Update () {
        if (Input.GetButton("Fire1") && FireTime >= 0.2f || Input.GetButton("Fire2") && FireTime >= 0.2f) 
        {
            Instantiate(Bullet, PlayerShot.position, PlayerShot.rotation);
            FireTime = 0;
            GetComponent<AudioSource>().Play();
        }
        if (FireTime < 0.2f)
            FireTime += Time.deltaTime;
	}
}
