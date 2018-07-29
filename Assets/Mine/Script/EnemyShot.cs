using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    public float delay;
    public float FireRate;
    public GameObject enemyBullet;
    public Transform shotSpawn;

    void Start()
    {
        InvokeRepeating("Shot", delay, FireRate);
    }

    void Update()
    {

    }

    void Shot()
    {
        Instantiate(enemyBullet, shotSpawn.position, shotSpawn.rotation);
        GetComponent<AudioSource>().Play();
    }
}
