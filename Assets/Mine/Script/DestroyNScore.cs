using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNScore : MonoBehaviour {

    public GameObject Explosion;
    public GameObject PlayerExplosion;
    public int score;
    public GameObject HGun;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Instantiate(PlayerExplosion, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameController.gameOver = true;
        }
        
        else if (other.tag == ("Bullet"))
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreCount.score += score;
            int rand= UnityEngine.Random.Range(1, 50);
            if (rand == 25)
            {
                Instantiate<GameObject>(HGun);
            }
        }
        else if (other.tag == ("Destroyer") || (other.tag==("Enemy")))
        {
            return;
        }
    }
}
